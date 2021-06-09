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
        int _x;                 //Position relative to blueprint, -1 for blocks in the AvailableBlockList
        int _y;
        string _color;          //Hex color
    }
}
