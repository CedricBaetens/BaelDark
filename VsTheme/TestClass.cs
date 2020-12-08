using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsTheme
{
    class TestClass
    {
        // This is comment

        public int TestProperty { get; set; }


        const string test = "123";
        private string _member = "test";

        public void TestMethod(string value)
        {
            var test = value;

            _member = test;
        }
    }

    interface IITestInterface
    {
        void DoStuff(int a);
    }

    enum TestEnum
    {
        Value1,
        Value2
    }

}
