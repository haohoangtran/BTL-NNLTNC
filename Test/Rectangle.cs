using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Rectangle
    {
        private int width
        {
            get;
            set;
        }
        private int height
        {
            get;
            set;
        }
       public Rectangle(int x, int y)
        {
            this.width = x;
            this.height = y;
        }
       public override string ToString()
       {
           return String.Format("width: {0}, heigh: {1}", this.width,this.height);
       }
            
    }
}
