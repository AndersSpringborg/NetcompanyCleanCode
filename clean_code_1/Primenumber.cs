using System.Collections.Generic;
using System.Linq;

namespace clean_code_1
{
    public class Primenumber
    {
        private ICollection<int> _primeNumbers = new List<int>(); 
        public string GetPrimes(int n)
        {
            _primeNumbers = CalculatePrimes(n);
             return PrimesToString(_primeNumbers);
        }

        private string PrimesToString(ICollection<int> primeNumbers)
        {
            return string.Join(" ", primeNumbers);
        }

        private ICollection<int> CalculatePrimes(int n)
        {
            foreach (int number in Enumerable.Range(1, n))
            {
                if (IsPrime(number))
                    _primeNumbers.Add(number);
            }

            return _primeNumbers;
        }

        public bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            
            int numbersToCheck = number / 2;
            for (int n = 2; n <= numbersToCheck; n++)
            {
                if (number % n == 0)
                    return false;
            }
            return true;
        }
    }
}