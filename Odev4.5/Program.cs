using System;

namespace Odev4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<double, string> myDictonary = new MyDictionary<double, string>();

            myDictonary.Add(12456391101, "Oğuzhan Karaoğlan");
            myDictonary.Add(12456391102, "Aydın Bal");
            myDictonary.Add(12456391103, "Burcu Batmaz");
            myDictonary.Add(10000000001, "Engin Demiroğ");

            myDictonary.MyList();
        }
    }
}
