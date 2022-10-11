/**************************************************************************
 *                                                                        *
 *  File:        UnitTest1.cs                                             *
 *  Copyright:   (c) 2022, Aioanei A., Burechita C., Sprinceana R, Chirila *
 *  Description: Text Comparator                                          *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestDiffernce
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod1()
        {
            List<string> test = new List<string>();
            Difference.Difference.DifferenceF(null, "ana are mere",ref test );
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod2()
        {
            List<string> test = new List<string>();
            Difference.Difference.DifferenceF("ana are mere", null, ref test);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod3()
        {
            List<string> test = new List<string>();
            Difference.Difference.DifferenceF(null, null, ref test);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("mere 1" ,Difference.Difference.DifferenceF("ana are mere" , "ana are pere", ref test));
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("0" ,Difference.Difference.DifferenceF("ana are mere" , "ana are mere", ref test));
        }

        [TestMethod]
        public void TestMethod6()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("bogdan nu mere si 1", Difference.Difference.DifferenceF("bogdan nu are mere si pere", "ana are pere", ref test));
        }

        [TestMethod]
        public void TestMethod7()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("razvan nu 1", Difference.Difference.DifferenceF("razvan nu are mere", "adrian are mere", ref test));
        }


        [TestMethod]
        public void TestMethod8()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("pere si prune 3", Difference.Difference.DifferenceF("andrei are mere", "andrei are pere si prune", ref test));
        }

        [TestMethod]
        public void TestMethod9()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("cirese 1", Difference.Difference.DifferenceF("cosmin are mere si pere si cirese", "cosmin nu are mere si pere", ref test));
        }

        [TestMethod]
        public void TestMethod10()
        {
            List<string> test = new List<string>();
            Assert.AreEqual("razvan merele 2", Difference.Difference.DifferenceF("razvan are merele in sacosa", "adrian are ciresele in sacosa", ref test));
        }
    }
}
