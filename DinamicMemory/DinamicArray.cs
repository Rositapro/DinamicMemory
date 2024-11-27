using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicMemory
{
    internal class DinamicArray
    {
        private int[] array;
        private int capacity;
        private int actualSize;

        public DinamicArray()
        {
            capacity = 4;
            array = new int[capacity];
            actualSize = 0;
        }

        public void Add(int value)
        {
            if (actualSize == capacity) 
            {
                Resize(capacity * 2);
            }

            array[actualSize] = value;
            actualSize++;
        }

        public void Eliminate(int index)
        {
            if (index < 0 || index >= actualSize)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            for (int i = index; i < actualSize - 1; i++)
            {
                array[i] = array[i + 1];
            }
            actualSize--;

            if (actualSize <= capacity / 4)
            {
                Resize(capacity / 2);
            }
        }

        public int[] ObtainElements()
        {
            int[] elements = new int[actualSize];
            Array.Copy(array, elements, actualSize);
            return elements;
        }

        private void Resize(int capacityNew)
        {
            int[] newArray = new int[capacityNew];
            Array.Copy(array, newArray, actualSize);
            array = newArray;
            capacity = capacityNew;
        }
        public void Modify(int index, int newValue)
        {
            if (index < 0 || index >= actualSize)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            // Modificamos el valor en el índice especificado
            array[index] = newValue;
        }

        public int Size
        {
            get { return actualSize; }
        }
    }
}

