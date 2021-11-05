using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length >= 2)
            {
                string notzero = original.Remove(0, 1);
                string result = notzero.Remove(notzero.Length - 1);
                return result;
            }
            else 
            {
                return original;
            }
           
        }
    }
}
