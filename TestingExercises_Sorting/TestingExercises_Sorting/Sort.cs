using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExercises_Sorting
{
    // Base class to implement generic colletion framework IComparer
    public class SortMethods : IComparer<ListElements>
    {
        public virtual int Compare(ListElements x, ListElements y)
        {
            return 0;
        }
    };
    // To SortByFirstName of Object List
    public class SortByFirstName : SortMethods
    {
        public override int Compare(ListElements x, ListElements y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
    // To SortByLastName of Object List
    public class SortByLastName : SortMethods
    {
        public override int Compare(ListElements x, ListElements y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
