namespace FaculcyArchiveXML.WinForms
{
    public class XmlAnalyzerContext
    {
        private IXmlAnalyzerStrategy _strategy;

        public XmlAnalyzerContext(IXmlAnalyzerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IXmlAnalyzerStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<Material> AnalyzeXml(string xmlFilePath)
        {
            return _strategy.AnalyzeXml(xmlFilePath);
        }
    }

}
