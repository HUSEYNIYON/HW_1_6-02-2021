using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_06_02_2021
{
    class ArrayHelper<T>
    {
        public static T Pop(ref T[] array)
        {
            int arrLen = array.Length;
            T delElem = array[arrLen - 1];
            T[] newArr = new T[arrLen - 1];


            for (int i = 0; i < arrLen - 1; i++)
            {
                newArr[i] = array[i];
            }
            array = newArr;
            return delElem;
        }
        public static int Push(ref T[] array, T newElement)
        {
            int arrLen = array.Length;
            T[] newArr = new T[arrLen + 1];
            for (int i = 0; i < arrLen + 1; i++)
            {
                newArr[i] = (i == arrLen) ? newElement : array[i];
            }
            array = newArr;
            return array.Length;
        }
        public static T Shift(ref T[] array)
        {
            int arrLen = array.Length;
            T delElement = array[0];
            T[] newArr = new T[arrLen - 1];
            for (int i = 1; i < arrLen; i++)
            {
                newArr[i - 1] = array[i];
            }
            array = newArr;
            return delElement;
        }
        public static int UnShift(ref T[] array, T newElement)
        {
            int arrLen = array.Length;
            T[] newArr = new T[arrLen + 1];
            for (int i = 0; i < arrLen + 1; i++)
            {
                newArr[i] = (i == 0) ? newElement : array[i - 1];
            }
            array = newArr;
            return array.Length;
        }
        public static T[] Slice(ref T[] array, int? Begin_Index = null, int? End_Index = null)
        {
            int arrLen = array.Length;
            Begin_Index = Begin_Index ?? 0;
            End_Index = End_Index ?? arrLen;
            if (End_Index < 0)
            {
                End_Index = arrLen + End_Index;
            }
            if (Begin_Index < 0)
            {
                Begin_Index = End_Index + Begin_Index;
            }
            int new_len = (End_Index - Begin_Index > 0) ? (int)(End_Index - Begin_Index) : 0;
            Console.WriteLine($"New arrLen = {new_len}");
            T[] newArr = new T[new_len];
            for (int i = 0; i < new_len; i++)
            {
                newArr[i] = array[i + (int)Begin_Index];
            }
            return newArr;
        }
    }
}
