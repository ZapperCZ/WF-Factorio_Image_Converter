using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio_Image_Converter
{
    class BlueprintTile
    {
        string _x;              //Position in blueprint
        string _y;              //Position in blueprint
        string _name;           //Name of the tile


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
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public BlueprintTile(string x, string y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
