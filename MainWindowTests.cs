using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void binary15TestReturned1111()
        {
            int n = 15;
            string res = "1111";
            Calculation o = new Calculation();
            string myres = o.binaryFunction(n);
            Assert.AreEqual(res, myres);

        }
        [TestMethod()]
        public void oct15returned17()
        {
            int n = 15;
            string res = "17"; // ожидаемый результат
            Calculation o = new Calculation();
            string myres = o.octFunction(n);  // фактический результат, вызов метода octFunction(n) из класса Calculation
            Assert.AreEqual(res, myres);
        }
        [TestMethod()]
        public void getHex11returnedTrue()
        {
            int n = 11;
            bool fl = true;
            Calculation o = new Calculation();
            bool res = o.getHex(n);
            Assert.AreEqual(fl, res);
        }
        [TestMethod()]
        public void hec15returnedF()
          {
              int n = 15;
              string res = "F";
              Calculation o = new Calculation();
              string myres = o.hexFunction(n);
              Assert.AreEqual(res, myres);
          }
          
        [TestMethod]
        public void chr1Test10returnedA()
        {
           int n = 10;
           char ch = 'A';
           Calculation o = new Calculation();
           char res = o.chr1(n);
            Assert.AreEqual(ch,res);
        }
        [TestMethod]
        public void sumReal2_5and4dec1returned6_5()  //sumReal(double op, int numeral, double dec1)
        {
            double op = 2.5;
            int num=4;
            double dec = 1;
            double res = 6.5;
            Calculation o = new Calculation();
            double myres = o.sumReal(op, num,dec);
            Assert.AreEqual(res, myres);
        }
     
    }
}