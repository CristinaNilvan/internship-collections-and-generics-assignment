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
        private int _listSize;
        private T[] _elements;

        public GenericList(int maxSize)
        {
            _maxSize = maxSize;
            _listSize = 0;
            _elements = new T[maxSize];
        }

        public int Count => _listSize;

        public void Add(T element)
        {
            if (_listSize > _maxSize)
                throw new InvalidOperationException("The list is full!");

            _elements[_listSize++] = element;
        }

        public void Remove()
        {
            _listSize--;

            if (_listSize < 0)
                throw new InvalidOperationException("Can't have less than 0 elements!");
        }

        public T GetElementAt(int index)
        {
            CheckIndex(index);

            return _elements[index];
        }

        public void SetElementAt(int index, T newElement)
        {
            CheckIndex(index);

            _elements[index] = newElement;
        }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            CheckIndex(firstIndex);
            CheckIndex(secondIndex);

            T auxElement = _elements[firstIndex];
            _elements[firstIndex] = _elements[secondIndex];
            _elements[secondIndex] = auxElement;
        }

        public void SwapElements(T firstElement, T secondElement)
        {
            int firstIndex = -1;
            int secondIndex = -1;
            
            for (int i = 0; i < _listSize; i++)
            {
                if (_elements[i].Equals(firstElement))
                    firstIndex = i;

                if (_elements[i].Equals(secondElement))
                    secondIndex = i;
            }

            if (firstIndex != -1 && secondIndex != -1)
            {
                _elements[firstIndex] = secondElement;
                _elements[secondIndex] = firstElement;
            }
            else
            {
                throw new NoMatchException("Not valid elements!");
            }
        }

        public void SwapElements(int index, T element)
        {
            int elementIndex = -1;

            for (int i = 0; i < _listSize; i++)
            {
                if (_elements[i].Equals(element))
                    elementIndex = i;
            }

            SwapElements(index, elementIndex);
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= _listSize || index >= _maxSize)
                throw new ArgumentOutOfRangeException("Not a valid index!");
        }
    }
}
