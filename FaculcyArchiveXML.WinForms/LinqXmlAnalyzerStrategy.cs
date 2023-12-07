using System.Text;
using System.Xml.Linq;

namespace FaculcyArchiveXML.WinForms
{
    public class LinqXmlAnalyzerStrategy : IXmlAnalyzerStrategy
    {
        public List<Material> AnalyzeXml(string xmlFilePath)
        {
            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            List<Material> materials = xmlDoc.Root.Elements("Material")
                .Select(materialElement => new Material
                {
                    Id = int.Parse(materialElement.Element("Id").Value),
                    Author = materialElement.Element("Author").Value,
                    Title = materialElement.Element("Title").Value,
                    FaculcyName = materialElement.Element("FaculcyName").Value,
                    Department = materialElement.Element("Department").Value,
                    MaterialType = materialElement.Element("MaterialType").Value,
                    Volume = materialElement.Element("Volume").Value,
                    CreationDate = DateTime.Parse(materialElement.Element("CreationDate").Value)
                })
                .ToList();

            return materials;
        }
    }
}
