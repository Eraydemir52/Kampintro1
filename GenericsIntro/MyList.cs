using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//yazdığın şey fark etmez
    {
        T[] items;
        //constructor //classı newler sen mylist() otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)// item=eleman
        {
            T[] tempArray = items;//geçici dizi
            items = new T[items.Length+1];
            for (int  i = 0;  i <tempArray.Length ;  i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
       }
    }
}
