using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UniqueChar;

namespace UniqueCharacterTest
{
    [TestFixture]
    public class TestCharacter
    {
        [Test]
        public void UniqueCharacterTest()
        {
            UniqueCharClass letterTest = new UniqueCharClass();
            List<char> output = new List<char>();
            string input = "blabla"; 
            output.Add('b');
            output.Add('l');
            output.Add('a');
            Assert.AreEqual(output, UniqueCharClass.UniqueCharacters(input));
        }
    }
}
