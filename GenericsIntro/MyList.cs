using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //<string> yazarsak sadece kelime alır. biz verdiğim tür ile çalışması için string,int yerine
                     //T veriyoruz. Yani bizim veri tipimizle çalışacak.
    {
        T[] items;
        public MyList() //ctor TABTAB (constructor)
        {
            items = new T[0];  //ARRAY'İN NEWLENME ZORUNLULUĞU VAR O YÜZDEN BU KOD ZORUNLU.
        }

        public void Add(T item)
        {
            T[] tempArray = items;  //önceki elemanlar kaybolmasın diye referans numarasını yeni bi diziye kaydettik.
            items = new T[items.Length+1]; //Yeni bir ad ekleyeceğimiz için eleman sayısını 1 artırıyoruz.
           
            for (int i = 0; i < tempArray.Length; i++) //tempArray'in başta kaydettiği elemanları geri çağırıyoruz.
            {
                items[i] = tempArray[i];    //Baştaki elemanları yeni diziye ekliyoruz.
            }
            items[items.Length - 1] = item;  //Yeni eklediğimiz adı ,yeni diziye ekledik.

            Console.WriteLine(item);
        }
    }
}
