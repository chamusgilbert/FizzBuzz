using NUnit.Framework;

namespace FizzBuzz
{
    class TDD
    {
        [Test]
        public static void TestDriven()
        {
            for (int i = 0; i < 100; i++)
            {
                //Program.Method1(i);
                Program.Method2(i);
                Program.Method3(i);
            }
        }
    }
}
