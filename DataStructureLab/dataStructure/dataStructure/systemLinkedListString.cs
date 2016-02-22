using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class systemLinkedListString : ICustomString
    {
        LinkedList<char> myString;

        public systemLinkedListString(string InitialString)
        {
            myString = new LinkedList<char>();
            char[] charArray = InitialString.ToCharArray();

            foreach (char ch in charArray)
            {
                myString.AddLast(ch);
            }
        }

        public void Insert(string stringToInsert, int index)
        {
            LinkedList<char> newList = new LinkedList<char>();
            char[] myStringToChar;
            char[] charArray = stringToInsert.ToCharArray();
            int internalCounter=0;

            myStringToChar = myString.ToArray();

            for (int i = 0; i < index; i++)
            {
                newList.AddLast(myStringToChar[i]);
            }

            for (int i = 0; i < charArray.Length; i++)
            {
                newList.AddLast(charArray[internalCounter]);

                internalCounter++;
            }
            for (int i = index; i < myStringToChar.Length; i++)
            {
                newList.AddLast(myStringToChar[i]);
            }
            myString = newList;

        }


        public int Length()
        {
            return myString.Count;
        }

        public void Remove(int StartIndex, int NumberOfCharactersToRemove)
        {
            LinkedList<char> newList = new LinkedList<char>();
            char[] myStringToChar;

            myStringToChar = myString.ToArray();

            for (int i = 0; i < StartIndex; i++)
            {
                newList.AddLast(myStringToChar[i]);
            }

            for (int i = StartIndex + NumberOfCharactersToRemove ; i < myStringToChar.Length; i++)
            {
                newList.AddLast(myStringToChar[i]);
            }
            myString = newList;
        }

        public void DisplayNodes()
        {
            string output = "";

            foreach (char ch in myString)
            {                
                output += ch.ToString();
            }
            Console.WriteLine(output);
        }
        public LinkedList<char> _myString
        {
            get
            {
                return myString;
            }
        }
    }

}
