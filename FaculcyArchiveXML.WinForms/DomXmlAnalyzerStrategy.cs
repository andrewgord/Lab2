using System.Text;
using System.Xml;

namespace FaculcyArchiveXML.WinForms
{

    public class DomXmlAnalyzerStrategy : IXmlAnalyzerStrategy
    {
        public List<Material> AnalyzeXml(string xmlFilePath)
        {
            List<Material> materials = new List<Material>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            foreach (XmlNode materialNode in xmlDoc.SelectNodes("//Material"))
            {
                Material material = new Material();

                foreach (XmlNode propertyNode in materialNode.ChildNodes)
                {
                    switch (propertyNode.Name)
                    {
                        case "Id":
                            material.Id = int.Parse(propertyNode.InnerText);
                            break;
                        case "Author":
                            material.Author = propertyNode.InnerText;
                            break;
                        case "Title":
                            material.Title = propertyNode.InnerText;
                            break;
                        case "FaculcyName":
                            material.FaculcyName = propertyNode.InnerText;
                            break;
                        case "Department":
                            material.Department = propertyNode.InnerText;
                            break;
                        case "MaterialType":
                            material.MaterialType = propertyNode.InnerText;
                            break;
                        case "Volume":
                            material.Volume = propertyNode.InnerText;
                            break;
                        case "CreationDate":
                            material.CreationDate = DateTime.Parse(propertyNode.InnerText);
                            break;
                    }
                }

                materials.Add(material);
            }

            return materials;
        }
    }

}
