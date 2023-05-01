using NUnit.Framework;
using System;

namespace Uzduotis13
{
    public class Class1
    {

        //Sukurti šiuos automatinius testus:
        //Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        
        [Test]
        public void Divide995By3WithoutRemainder() 
        {
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //Testas “žalias” jeigu šiandien trečiadienis(naudoti ChatGPT, kad išsiaiškinti kaip
        //C# dirbti su dienomis)

        [Test]
        public void TodayIsWednesday()
        { 
            DayOfWeek expectedResult = DayOfWeek.Wednesday;

            DayOfWeek actualResult = DateTime.Now.DayOfWeek;

            Assert.Equals(expectedResult, actualResult);
        }

        //Testas “žalias” jeigu dabar yra 13h (naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti
        //su valandomis)

        [Test]
        public void TimeNowIs13h()
        {
            int expectedResult = 13;

            int actualResult = DateTime.Now.Hour;

            Assert.Equals(expectedResult, actualResult);
        }

        //Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai

        [Test]
        public void ThereAre4EvenNumbersBetween1And10()
        {
            int expectedResult = 4;

            int actualResult = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    actualResult++;
                }
            }
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
