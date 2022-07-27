using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class GenericList<T>
    {
        private int _maxSize;
        private int _currentIndex;
        private T[] _elements;

        public GenericList(int maxSize)
        {
            _maxSize = maxSize;
            _currentIndex = 0;
            _elements = new T[maxSize];
        }
    }
}
