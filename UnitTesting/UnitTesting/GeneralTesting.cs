using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rekenmachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting.UnitTesting
{
    [TestClass]
    public class GeneralTesting
    {
        [TestMethod]
        public void AddSpecialNumber()
        {
            MainPage item = new MainPage();
            object sendobject = new object();
            EventArgs sendargs = new EventArgs();
            NUnit.Framework.Assert.DoesNotThrow(() => item.piClicked(sendobject, sendargs));
        }

        [TestMethod]
        public void AddRegularNumber()
        {
            MainPage item = new MainPage();
            object sendobject = new object();
            EventArgs sendargs = new EventArgs();
            NUnit.Framework.Assert.DoesNotThrow(() => item.sevenClicked(sendobject, sendargs));
        }

        [TestMethod]
        public void AddSpecialCalc()
        {
            MainPage item = new MainPage();
            object sendobject = new object();
            EventArgs sendargs = new EventArgs();
            NUnit.Framework.Assert.DoesNotThrow(() => item.factorialClicked(sendobject, sendargs));
        }

        [TestMethod]
        public void TestClearValues()
        {
            MainPage item = new MainPage();
            object sendobject = new object();
            EventArgs sendargs = new EventArgs();
            NUnit.Framework.Assert.DoesNotThrow(() => item.ceClicked(sendobject, sendargs));
        }

        [TestMethod]
        public void GenerateFractionedValue()
        {
            MainPage item = new MainPage();
            object sendobject = new object();
            EventArgs sendargs = new EventArgs();
            NUnit.Framework.Assert.DoesNotThrow(() => item.decimalClicked(sendobject, sendargs));
        }
    }
}