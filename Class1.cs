using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class1
    {
        double wight;
        double height;
        string Color;
        string Material;
        string forma;

        public Class1(double wight, double height, string color, string material, string forma)

        {
            this.wight = wight;
            this.height = height;
            Color = color;
            Material = material;
            this.forma = forma;
        }

        public string ReturnForm()
        {
            return forma;
        }
        string ReturnColorTable()
        {
            return Color;
           
        }  
        
        }
    
    }

