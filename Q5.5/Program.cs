using System;


namespace Q5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        (string name, string lastname, int age, bool haveapet, int petamount) anketa;

        static (string name,string lastname,int age) Anketa()
        {
            (string name,string lastname, int age) anketa;
            Console.WriteLine("Ваше имя:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            anketa.lastname = Console.ReadLine();
            string age;
            int intage;
            do
            {
                Console.WriteLine("Ваш возраст:");
                age = Console.ReadLine();
            }
            while (ChekNum(age, out intage));
            anketa.age = intage;
            return anketa;
        }
        static bool CheckNum (string number,out int corrnumber)
        {
            if (int.TryParse(number,out int intnum))
            {
                if (intnum>0)
                {
                    corrnumber = intnum;
                    return false;
                }
                {
                    corrnumber = 0;
                    return true;
                }
            }
        }
        static string[] CreateArrPets(int num)
        {
            var result = new string[num];

            return result;
        }
    }
}
