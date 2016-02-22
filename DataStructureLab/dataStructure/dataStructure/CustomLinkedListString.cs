using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class CustomLinkedListString : ICustomString
    {
        Node Head;


        public CustomLinkedListString(string initialString)
        {
            char[] charArray = initialString.ToCharArray();

            Head = new Node(charArray[0], null);

            Node lastnode = Head;

            for (int i = 1; i < charArray.Length; i++)
            {
                Node newnode = new Node(charArray[i], lastnode._next);
                lastnode._next = newnode;
                lastnode = newnode;
            }
            
        }

        public void createNewLinkList(char[] charArray)
        {
            Head = new Node(charArray[0], null);

            Node lastnode = Head;

            for (int i = 1; i < charArray.Length; i++)
            {
                Node newnode = new Node(charArray[i], lastnode._next);
                lastnode._next = newnode;
                lastnode = newnode;
            }
        }

        public void Insert(string stringToInsert, int index)
        {
            string myString;

            myString = ListToString();

            char[] myStringToChar;
            char[] charArray = stringToInsert.ToCharArray();
            
            int internalCounter = 0;

            myStringToChar = myString.ToArray();
            char[] newString = new char[myStringToChar.Length + stringToInsert.Length];

            for (int i = 0; i < index; i++)
            {
                newString[i] = myStringToChar[i];
            }
            for (int i = index; i < index + stringToInsert.Length; i++)
            {
                newString[i] = charArray[internalCounter];
                internalCounter++;
            }
            internalCounter = index;
            for (int i = index + stringToInsert.Length; i < newString.Length; i++)
            {
                newString[i] = myString[internalCounter];
                internalCounter++;
            }
            createNewLinkList(newString);
            
        }

        public int Length()
        {
            int length = 0;
            Node nextNode;

            if (Head != null)
            {
                length++;
                nextNode = Head._next;
                while (nextNode._next != null)
                {
                    length++;
                    nextNode = nextNode._next;
                }
                length++;
            }
            return length;
        }

        public void Remove(int StartIndex, int NumberOfCharactersToRemove)
        {
            char[] myStringToChar;
            string myString;

            myString = ListToString();
            myStringToChar = myString.ToArray();

            int internalCounter = StartIndex;

            char[] charArray = new char[myStringToChar.Length - NumberOfCharactersToRemove];

            

            for (int i = 0; i < StartIndex; i++)
            {
                charArray[i] = myStringToChar[i];
            }

            for (int i = StartIndex + NumberOfCharactersToRemove; i < myStringToChar.Length; i++)
            {
                charArray[internalCounter] = myStringToChar[i];
                internalCounter++;
            }
            createNewLinkList(charArray);
        }
        public string ListToString()
        {
            Node nextNode;
            string internalString="";

            if (Head != null)
            {
                internalString = Head._letter.ToString();
                nextNode = Head._next;
                while (nextNode._next != null)
                {
                    internalString += nextNode._letter.ToString();
                    nextNode = nextNode._next;
                }
                internalString += nextNode._letter.ToString();
            }
            return internalString;
        }
        
        public Node _head
        {
            get
            {
                return Head;
            }
        }

    }
}
