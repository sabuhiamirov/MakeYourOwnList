using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherTest
{
    public  class TestDll
    {
     
        private int _a; //field
        private int _b;  //field

        public void setA(int a)
        {
            _a = a;
        }

        private void Sum()
        {
            Console.WriteLine(_a+_b);
        }
    }
   
}
