using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio_Image_Converter
{
    class BlueprintBlock
    {
        string _entityNumber;   //This is not ID of game block but its ID in blueprint
        string _name;           //Name of the block
        string _x;              //Position in blueprint
        string _y;              //Position in blueprint

        public string EntityNumber
        {
            get { return _entityNumber; }
            set { _entityNumber = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public BlueprintBlock(string entityNumber, string name, string x, string y)
        {
            EntityNumber = entityNumber;
            Name = name;
            X = x;
            Y = y;
        }
    }
}
