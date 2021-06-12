using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio_Image_Converter
{
    class BlueprintBlock_UndergroundBelt : BlueprintBlock
    {
        string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public BlueprintBlock_UndergroundBelt(string entityNumber, string name, string x, string y, string type) : base(entityNumber, name, x, y)
        {
            Type = type;
        }
    }
}
