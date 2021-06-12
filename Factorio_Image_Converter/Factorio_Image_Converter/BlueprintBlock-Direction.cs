using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio_Image_Converter
{
    class BlueprintBlock_Direction : BlueprintBlock
    {
        string _direction;          //Direction of the block
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        public BlueprintBlock_Direction(string entityNumber, string name, string x, string y, string direction) : base(entityNumber,name,x,y)
        {
            Direction = direction;
        }
    }
}
