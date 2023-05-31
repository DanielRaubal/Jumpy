using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Jumpy
{
    class BitmapManipulation
    {
        public static string GetBitmapWidth(Bitmap bit)
        {
            if (bit != null)
            {
                return bit.Width.ToString();
            }
            return "no image";
        }

        public static string GetBitmapHeight(Bitmap bit)
        {
            if (bit != null)
            {
                return bit.Height.ToString();
            }
            return "no image";
        }
    }
}
