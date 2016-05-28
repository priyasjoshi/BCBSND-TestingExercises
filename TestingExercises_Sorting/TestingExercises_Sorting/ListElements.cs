using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExercises_Sorting
{
    // Class to create User Defined List 
    public class ListElements
    {
        private string _FirstName;
        private string _LastName;
        public ListElements() { }
        public ListElements(string FirstName, string LastName)
        {
            _FirstName = FirstName;
            _LastName = LastName;
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
    }
}
