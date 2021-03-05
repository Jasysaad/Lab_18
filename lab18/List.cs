using System;
using System.Collections.Generic;
using System.Text;

namespace lab18
{
    class List
    {
        private int _count = 0;
        private readonly string[] _array;

        public List(int maxlength)
        {
            _array = new string[maxLength];

        }
        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count ==0;
        }

        public bool IsFull()
        {
            return _count ==array.Length;
        }

        static bool Insert(string value)
        {
            if { isFull() }
            {
                return false;
            }
            _array[_count] = value;
            _count++;
            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }

            _count--;
        }

    }
}
