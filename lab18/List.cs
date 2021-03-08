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
            _array = new string[maxlength];

        }
        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }

        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;
            }
            _array[_count] = value;
            _count++;
            return true;
        }

        public bool RemoveAt(int index)
        {

            if (index > _count)
            {
                return false;
            }
            else
            {
                for (int i = index; i < _count; i++)
                {
                    _array[i] = _array[i + 1];
                }
                foreach (var item in _array)
                {

                    Console.WriteLine(item);
                }
                _count--;
                return true;
            }
            //_count=_count--;
            //// _count--;
            //Console.WriteLine(index);
            //Console.WriteLine(_count);


            //if (index < _count)
            //{
            //    return false;
            //}
            //else
            //{
            //    for (int i = index; i < _count; i++)
            //    {
            //        _array[i] = _array[i + 1];

            //    }

            // }
        }
        public void PrintReverse()
        {
            for (int i = _count; i >= 0; i--)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public bool InsertAt(int index, Object O)
        {
            var value = O.ToString();
            if (index > _count)
            {
                return false;
            }
            else
            {
                _array[index] = value;
                _count++;
                
                foreach (var item in _array)
                {
                    Console.WriteLine(item);
                }
                return true;
            }
            
            }
        }
    }

