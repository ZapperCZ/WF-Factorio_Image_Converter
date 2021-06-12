using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio_Image_Converter
{
    class BlueprintIcon
    {
        string _type;       //Icon type
        string _name;       //Name of the block
        string _index;      //Index

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Index
        {
            get { return _index; }
            set { _index = value; }
        }
        public BlueprintIcon(string type, string name, string index)
        {
            Type = type;
            Name = name;
            Index = index;
        }
    }
}
