using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio_Image_Converter
{
    class Block
    {
        string _name;           //Name of the block
        string _color;          //Hex color

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Block(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
