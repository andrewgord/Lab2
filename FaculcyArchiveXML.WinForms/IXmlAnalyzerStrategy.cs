namespace FaculcyArchiveXML.WinForms
{
    public interface IXmlAnalyzerStrategy
    {
        List<Material> AnalyzeXml(string xmlFilePath);
    }
}
