using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    public interface ICustomString
    {

        void Insert(string stringToInsert, int index);

        void Remove(int StartIndex, int NumberOfCharactersToRemove);

        int Length();

    }
}
