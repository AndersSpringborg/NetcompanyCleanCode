using clean_code_1;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        private Primenumber _primenumber; 
        [SetUp]
        public void Setup()
        {
            _primenumber = new Primenumber();
        }

        [Test]
        public void Given0ReturnEmptyString()
        {
            var actual = _primenumber.GetPrimes(0);
            var expected = "";
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Given2Return2()
        {
            var actual = _primenumber.GetPrimes(2);
            var expected = "2";
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Given12ReturnStringWith235711()
        {
            var actual = _primenumber.GetPrimes(12);
            var expected = "2 3 5 7 11";
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given45ReturnStringWith()
        {
            var actual = _primenumber.GetPrimes(45);
            var expected = "2 3 5 7 11 13 17 19 23 29 31 37 41 43";
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Is3APrimeShouldReturnTrue()
        {
            Assert.IsTrue(_primenumber.IsPrime(3));
        }
        
        [Test]
        public void Is4APrimeShouldReturnFalse()
        {
            Assert.IsFalse(_primenumber.IsPrime(4));
        }
    }
}