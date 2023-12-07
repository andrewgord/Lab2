using System.Text;
using System.Xml;

namespace FaculcyArchiveXML.WinForms
{
    public class SaxXmlAnalyzerStrategy : IXmlAnalyzerStrategy
    {
        public List<Material> AnalyzeXml(string xmlFilePath)
        {
            List<Material> materials = new List<Material>();

            using (XmlReader reader = XmlReader.Create(xmlFilePath))
            {
                Material currentMaterial = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "Material":
                                currentMaterial = new Material();
                                break;
                            case "Id":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.Id = int.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            case "Author":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.Author = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Title":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.Title = reader.ReadElementContentAsString();
                                }
                                break;
                            case "FaculcyName":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.FaculcyName = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Department":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.Department = reader.ReadElementContentAsString();
                                }
                                break;
                            case "MaterialType":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.MaterialType = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Volume":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.Volume = reader.ReadElementContentAsString();
                                }
                                break;
                            case "CreationDate":
                                if (currentMaterial != null)
                                {
                                    currentMaterial.CreationDate = DateTime.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Material")
                    {
                        materials.Add(currentMaterial);
                        currentMaterial = null;
                    }
                }
            }

            return materials;
        }
    }
}
