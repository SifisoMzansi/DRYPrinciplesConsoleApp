using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryDemoLibrary
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeId(string firstName, string lastName)
        {
            return $@"{GetPartOfName(firstName, 4) }{GetPartOfName( lastName , 4) }{DateTime.Now.Microsecond}";
        }

        private string GetPartOfName(string name, int numberOfCharacters)
        {
            return (name.Length > numberOfCharacters) ? name.Substring(0, numberOfCharacters) : name;             
        }
    }
}
