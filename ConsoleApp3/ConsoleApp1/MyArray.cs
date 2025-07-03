using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyArray
    {
        private const int DefaultSize = 5;

        private int[] _dataArray;
        private int _currentIdex = -1;

        public MyArray()
        {
            _dataArray = new int[DefaultSize];
        }
        public MyArray(int size)
        {
            // Initialize the array with a default size
            _dataArray = new int[size];
            _currentIdex = -1;
        }   
        public void Add(int value) 
        {
            _currentIdex++;
            _dataArray[_currentIdex] = value;

            if (_currentIdex == _dataArray.Length - 1)
            {

                int[] newArray = new int[_dataArray.Length * 2];
                for (int i = 0; i < _dataArray.Length; i++)
                {
                    newArray[i] = _dataArray[i];
                }

                _dataArray = newArray;
            }
        }

        public int GetLength()
        {
            return (_currentIdex + 1);
        }

        public int GetItem(int index) 
        {
            if (_currentIdex == -1)
            {
                return -1;
            }

            return _dataArray[index];
        }

    }
}
