namespace DataClassGenerator
{
    public partial class TextTemplate : ITemplate
    {
        public string NameSpace { get; }

        public TextTemplate(string nameSpace)
        {
            NameSpace = nameSpace;
        }
    }
}