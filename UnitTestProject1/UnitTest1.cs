using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime centuryBegin = new DateTime(2021, 4, 29); //Событие от которого рассчитывается количество тактов
            DateTime currentDate = DateTime.Now;
            long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
            MessageBox.Show(elapsedTicks.ToString)();
        }
    }
}
