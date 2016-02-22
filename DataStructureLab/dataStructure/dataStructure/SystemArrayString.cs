using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class SystemArrayString : ICustomString
    {
        private char[] myString;

        public SystemArrayString(string initialString)
        {
            myString = initialString.ToCharArray();
        }
        
        public void Insert(string stringToInsert, int index)
        {
            char[] InsertCharArray;
            char[] newCharArray;
            int internalCounter=0;

            int insertedStringLength;
            int mystringLength;

            mystringLength = myString.Length;
            InsertCharArray = stringToInsert.ToCharArray();
            insertedStringLength = stringToInsert.Length;

            newCharArray = new char[insertedStringLength + mystringLength];

            for (int i = 0; i < index; i++)
            {
                newCharArray[i] = myString[i];
            }
            for (int i = index; i< index+insertedStringLength; i++)
            {
                newCharArray[i] = InsertCharArray[internalCounter];
                internalCounter++;
            }
            internalCounter = index;
            for (int i = index+insertedStringLength; i < newCharArray.Length; i++)
            {
                newCharArray[i] = myString[internalCounter];
                internalCounter++;
            }
            myString = newCharArray;
        }

        public int Length()
        {
           return myString.Length;
        }

        public void Remove(int StartIndex, int NumberOfCharactersToRemove)
        {
            char[] newCharArray;
            int internalCounter=StartIndex;

            newCharArray = new char[myString.Length - NumberOfCharactersToRemove];

            for (int i = 0; i < StartIndex; i++)
            {
                newCharArray[i] = myString[i];
            }

            for (int i = StartIndex + NumberOfCharactersToRemove; i < myString.Length; i++)
            {
                newCharArray[internalCounter] = myString[i];
                internalCounter++;
            }
            myString = newCharArray;
        }
        public char[] _myString
        {
            get
            {
                return myString;
            }
        }
    }
}
