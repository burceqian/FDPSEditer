using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDPSEditerFinal
{
    public static class ComLib
    {
        public static string GetHex(int decNum)
        {
            return decNum.ToString("x").PadLeft(2, '0');
        }

        public static int GetDec(string hexNum)
        {
            return Convert.ToInt32(hexNum, 16);
        }

        public static bool GetAction(int pValue)
        {
            if (pValue.ToString("x").PadLeft(2, '0') == "80")
            {
                return true;
            }
            return false;
        }

        public static Icon GetIcon(Bitmap icon)
        {
            IntPtr Hicon = icon.GetHicon();
            return Icon.FromHandle(Hicon);
        }
    }
}
