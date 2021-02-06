using System;
using System.Collections.Generic;
using System.Threading;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Denizli");
            sehirler.Add("İzmir");

            Console.WriteLine(sehirler.Count);
            //sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Urfo");
            sehirler2.Add("Ağrı");
            Console.WriteLine(sehirler2.Count);
            
            
        }
    }
    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray; //Geçici dizi yeni eleman ekleyince eskileri tutması için.
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
