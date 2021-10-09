using System;
using testDll;
using pdTcpIpService;
using System.Collections.Generic;



namespace TeacherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCs tstCs = new TestCs();

            //tstCs.setName("Sabuhi");
            //tstCs.setName("Cavid");
            //tstCs.setName("Ferid");


            //  Console.WriteLine(tstCs.getId());
            //Console.WriteLine(tstCs.getName());

            //Console.WriteLine(tstCs.lastName);

              MyList<string> myList = new MyList<string>();

            myList.Add("Sabuhi");

            Console.WriteLine(myList.Length);

            myList.Add("Isi");

            Console.WriteLine(myList.Length);

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

        }
    }

    class TestCs
    {
        string _name;
        int _id;
        string _lastName;

       
        public int getId()
        {
            return _id;
        }
        public string getName()
        {
            return "Mr: "+ _name;
        }

        public void setName(string name)
        {
            this._id++;
            _name = name;
        }

    }
}
