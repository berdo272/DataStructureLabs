using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    public class SystemString : ICustomString
    {
        string myString;

        public SystemString(string mystring)
        {
            myString = mystring;
        }

        public void Insert(string stringToInsert, int index)
        {
            char[] charArray;

            int insertedStringLength;
            int mystringLength;
            string newstring = "";

            charArray = myString.ToCharArray();
            insertedStringLength = stringToInsert.Length;
            mystringLength = myString.Length;

            for (int i=0; i<index; i++)
            {
                newstring += charArray[i];                
            }
            newstring += stringToInsert;
            for (int i = index; i < mystringLength; i++)
            {
                newstring += charArray[i];
            }
            myString = newstring;

        }

        public int Length()
        {
            return myString.Count();
        }

        public void Remove(int StartIndex, int NumberOfCharactersToRemove)
        {
            char[] charArray;
            string newstring = "";
            int mystringLength = myString.Length;

            charArray = myString.ToCharArray();

            for (int i = 0; i < StartIndex; i++)
            {
                newstring += charArray[i];
            }
            for (int i = StartIndex + NumberOfCharactersToRemove; i < mystringLength; i++)
            {
                newstring += charArray[i];
            }
            myString = newstring;

        }

        public string _myString
        {
            get
            {
                return myString;
            }
        }
    }
}
