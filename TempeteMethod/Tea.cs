using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempeteMethod
{
    public class Tea:Drink
    {
        public override void AddedAccessories()
        {
            Console.WriteLine("Dodawanie cytryny");
        }
        public override void Brew()
        {
            Console.WriteLine("Wkładanie torebki do wrzątku");
        }
        public override bool CheckClientWantAccessories()
        {
            string answer = _answer();
            if (answer.StartsWith("tak"))
                return true;
            else return false;
        }
        private string _answer()
        {
            string answer = null;
            Console.WriteLine("Czy życzy sobie pani cytryny do herbaty?");
            answer= Console.ReadLine();
            if (answer == null)
                return "nie";
            return answer;
        }
    }
}
