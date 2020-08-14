using System.Collections.Generic;

namespace DataClassGenerator.Material
{
    public class TableInfo
    {
        public string Name { get; set; }

        public IEnumerable<ColumnInfo> ColumnInfos { get; set; }
    }
}