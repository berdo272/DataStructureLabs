using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<int,ICustomString> sortedlist = new SortedList<int,ICustomString>();

            SystemString ss = new SystemString("This  Easy Test");

            ss.Insert("is a ", 5);

            Console.WriteLine(ss._myString);

            Console.WriteLine(ss.Length());

            ss.Remove(5, 3);

            Console.WriteLine(ss._myString);

            Console.ReadKey();
            Console.WriteLine();

            SystemArrayString sas = new SystemArrayString("This  Medium Test");

            sas.Insert("is a ", 5);

            Console.WriteLine(sas._myString);

            Console.WriteLine(sas.Length());

            sas.Remove(5, 3);

            Console.WriteLine(sas._myString);

            Console.ReadKey();
            Console.WriteLine();

            systemLinkedListString slls = new systemLinkedListString("These  Hard Test");

            slls.Insert("is a ", 5);

            slls.DisplayNodes();

            Console.WriteLine(slls.Length());

            slls.Remove(5, 3);

            slls.DisplayNodes();

            Console.ReadKey();
            Console.WriteLine();

            CustomLinkedListString clls = new CustomLinkedListString("This  Very Hard Test");

            clls.Insert("is a ", 5);

            Console.WriteLine(clls.ListToString()); 
            Console.WriteLine(clls.Length());

            clls.Remove(5, 3);

            Console.WriteLine(clls.ListToString());

            Console.ReadKey();

            sortedlist.Add(clls.Length(),clls);
            sortedlist.Add(slls.Length(),slls);
            sortedlist.Add(ss.Length(),ss);
            sortedlist.Add(sas.Length(),sas);

            Console.ReadKey();
        }
    }
}
