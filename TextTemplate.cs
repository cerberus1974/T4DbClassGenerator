using DataClassGenerator.Material;

namespace DataClassGenerator
{
    public partial class TextTemplate : ITemplate
    {
        public string NameSpace { get; }

        public TableInfo TableInfo { get; }

        public TextTemplate(string nameSpace, TableInfo tableInfo)
        {
            NameSpace = nameSpace;
            TableInfo = tableInfo;
        }
    }
}