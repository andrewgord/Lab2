using System.Data;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace FaculcyArchiveXML.WinForms
{
    public partial class MainForm : Form
    {
        private List<Material> generalMaterials;
        private List<Material> filteredMaterials;
        private string xmlFilePath = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            // Additional styles

            this.saxButton.Checked = true;

            //

            this.generalMaterials = new List<Material>();
            this.filteredMaterials = new List<Material>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files|*.xml|All Files|*.*";
            openFileDialog.Title = "Select an XML File";

            this.ClearAllControls();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = openFileDialog.FileName;
                this.LoadDataBasedOnStrategy(openFileDialog.FileName);
                this.FillFilterData();
            }
        }

        private void ClearAllControls()
        {
            this.richTextBox1.Clear();
            this.generalMaterials.Clear();
            this.filteredMaterials.Clear();

            this.authorsComboBox.Items.Clear();
            this.faculcyComboBox.Items.Clear();
            this.departamentComboBox.Items.Clear();

            this.authorsComboBox.SelectedIndex = -1;
            this.faculcyComboBox.SelectedIndex = -1;
            this.departamentComboBox.SelectedIndex = -1;

            this.authorsComboBox.Text = string.Empty;
            this.faculcyComboBox.Text = string.Empty;
            this.departamentComboBox.Text = string.Empty;
        }
        private void LoadDataBasedOnStrategy(string xmlFilePath)
        {
            IXmlAnalyzerStrategy strategy = null;
            if (this.saxButton.Checked)
            {
                strategy = new SaxXmlAnalyzerStrategy();
            }
            else
            {
                if (this.domButton.Checked)
                {
                    strategy = new DomXmlAnalyzerStrategy();
                }
                else
                {
                    strategy = new LinqXmlAnalyzerStrategy();
                }
            }

            var context = new XmlAnalyzerContext(strategy);
            var dataFromXML = context.AnalyzeXml(xmlFilePath);
            this.InsertPretifiedMaterialsIntoRichTextBox(dataFromXML, isGeneralLoading: true);

        }

        private void InsertPretifiedMaterialsIntoRichTextBox(List<Material> materials, bool isGeneralLoading = false)
        {
            if (isGeneralLoading)
            {
                this.generalMaterials = materials;
            }

            this.richTextBox1.Text = string.Empty;
            foreach (var material in materials)
            {
                string content = string.Empty;

                content += $"<---{material.Id}--->\n";
                content += $"{material.Author}\n";
                content += $"{material.Title}\n";
                content += $"{material.FaculcyName}\n";
                content += $"{material.Department}\n";
                content += $"{material.MaterialType}\n";
                content += $"{material.Volume}\n";
                content += $"{material.CreationDate}\n";

                this.richTextBox1.Text += content;
            }


        }

        private void FillFilterData()
        {
            var authors = this.generalMaterials.Select(x => x.Author).Distinct().ToList();
            this.authorsComboBox.Items.Add(string.Empty);
            this.authorsComboBox.Items.AddRange(authors.ToArray());

            var faculcies = this.generalMaterials.Select(x => x.FaculcyName).Distinct().ToList();
            this.faculcyComboBox.Items.Add(string.Empty);
            this.faculcyComboBox.Items.AddRange(faculcies.ToArray());

            var departaments = this.generalMaterials.Select(x => x.Department).Distinct().ToList();
            this.departamentComboBox.Items.Add(string.Empty);
            this.departamentComboBox.Items.AddRange(departaments.ToArray());
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                SaveMaterialsToXml(filePath);

                MessageBox.Show("Уcпішно збережено.");
            }
        }

        private void SaveMaterialsToXml(string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Material>));

                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, filteredMaterials);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збережені в XML: {ex.Message}");
            }
        }

        private void authorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFiltering();
        }

        private void ProcessFiltering()
        {
            var author = authorsComboBox.SelectedItem?.ToString();
            var faculcy = faculcyComboBox.SelectedItem?.ToString();
            var departament = departamentComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(author) || !string.IsNullOrEmpty(faculcy) || !string.IsNullOrEmpty(departament))
            {
                this.filteredMaterials = this.generalMaterials
                    .Where(x =>
                        (string.IsNullOrEmpty(author) || x.Author == author) &&
                        (string.IsNullOrEmpty(faculcy) || x.FaculcyName == faculcy) &&
                        (string.IsNullOrEmpty(departament) || x.Department == departament))
                    .ToList();
            }
            else
            {
                this.filteredMaterials = this.generalMaterials;
            }

            this.InsertPretifiedMaterialsIntoRichTextBox(this.filteredMaterials);
        }

        private void faculcyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFiltering();
        }

        private void departamentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFiltering();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EnsureToClose();
        }

        private void EnsureToClose()
        {
            DialogResult result = MessageBox.Show("Чи дійсно ви хочете завершити роботу з програмою?", "Закриття", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog xsltDialog = new OpenFileDialog();
            xsltDialog.Filter = "XSLT Files|*.xslt|All Files|*.*";

            if (xsltDialog.ShowDialog() == DialogResult.OK)
            {
                var xsltFilePath = xsltDialog.FileName;

                SaveFileDialog htmlDialog = new SaveFileDialog();

                if (htmlDialog.ShowDialog() == DialogResult.OK)
                {
                    string htmlFilePath = htmlDialog.FileName + ".html";

                    this.ConvertToHtml(this.xmlFilePath, xsltFilePath, htmlFilePath);

                    MessageBox.Show("Успішна конвертація!");
                }
            }
        }


        private void ConvertToHtml(string xmlFilePath, string xsltFilePath, string outputHtmlFilePath)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltFilePath);

            using (XmlWriter writer = XmlWriter.Create(outputHtmlFilePath))
            {
                xslt.Transform(xmlFilePath, writer);

            }
        }
    }
}
