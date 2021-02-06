using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4._5
{
    class MyDictionary<Keys, Values>
    {
        Keys[] keys;
        Values[] values;
        public MyDictionary()
        {
            keys = new Keys[0];
            values = new Values[0];
        }
        public void Add(Keys key, Values value)
        {
            Keys[] tempArray1 = keys;
            Values[] tempArray2 = values;

            keys = new Keys[keys.Length + 1];
            values = new Values[values.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i];
            }

            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
        }

        public void MyList()  //Listeleme kodunu for ile getirdik.
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Tc Kimlik No = " + keys[i] + "  *******" + " İsim Soyisim = " + values[i]);
            }
        }
    }
}