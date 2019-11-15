using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Calculation
    {
        public string strF = "";
       /* string strF1 = "";
        string strF2 = "";*/

        public string binaryFunction(int n)
        {
            int tmp = n % 2;
            if (n >= 2)
                binaryFunction(n / 2);
            strF += tmp.ToString();
            return strF;
        }
        public string octFunction(int n)
        {
            int tmp = n % 8;
            if (n >= 8)
                octFunction(n / 8);
            strF += tmp.ToString();
            return strF;
        }
        public char chr1(int num)  // vozvrashaet ot A-F
        {
            char ch = 'g';
            if (num == 10)
                ch = 'A';
            if (num == 11)
                ch = 'B';
            if (num == 12)
                ch = 'С';
            if (num == 13)
                ch = 'D';
            if (num == 14)
                ch = 'E';
            if (num == 15)
                ch = 'F';
            return ch;
        }
        public bool getHex(int num)
        {
            if (num > 9 && num < 16)
                return true;
            else
                return false;
        }
        public string hexFunction(int n)
        {
            int tmp = n % 16;
            if (n >= 16)
                hexFunction(n / 16);
            if (getHex(tmp))
                strF = chr1(tmp).ToString();
            else
                strF = tmp.ToString();
            return strF;
        }
        public double sumReal(double op, int numeral, double dec1)
        {
            return op + (double)numeral / dec1;
        }


        public double sumRealPoint(double op, int numeral, double dec1)
        {
            return (op * 10) + (double)numeral / dec1;
        }
    }
}
