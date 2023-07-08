﻿using Phil_s_Lending_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil_s_Lending_Library.Classes
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> items;

        public Backpack()
        {
            items = new List<T>();
        }
        public void Pack(T item)
        {
            if (item != null)
            {
                items.Add(item);
            }
        }
        public T Unpack(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                T item = items[index];
                items.RemoveAt(index);
                return item;
            }
            throw new IndexOutOfRangeException();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}
