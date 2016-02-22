using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Node
    {
        Node Next;
        char Letter;

        public Node(char letter, Node next)
        {
            this.Next = next;
            this.Letter = letter;
        }

        public Node _next
        {
            get
            {
                return Next;
            }
            set
            {
                Next = value;
            }
        }
        public char _letter
        {
            get
            {
                return Letter;
            }
        }
    }
}
