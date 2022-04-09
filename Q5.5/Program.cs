using System;


namespace Q5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Anketa();
        }
        

        static (string name,string lastname,int age, bool haveapet, int petamount,byte colors) Anketa()
        {
            (string name,string lastname, int age, bool haveapet, int petamount, byte colors) anketa;
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
            while (CheckNum(age, out intage));
            anketa.age = intage;
            Console.WriteLine("У вас есть питомец,да или нет?");
            string havepet = Console.ReadLine();
            if (havepet=="Да" & havepet == "да")
                    anketa.haveapet =true;
            else anketa.haveapet = false;
            if (anketa.haveapet == true)
                Console.WriteLine("Сколько у вас питомцев");
            anketa.petamount = int.Parse( Console.ReadLine());
            CreateArrPets(anketa.petamount);
            
            Console.WriteLine("Введите ваши любимые цвета");
            anketa.colors = byte.Parse(Console.ReadLine());
            CreateArrColors(anketa.colors);
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
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ваш питомец номер{0}:", i);
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static string[] CreateArrColors(int num)
        {
            var result = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ваш питомец номер{0}:", i);
                result[i] = Console.ReadLine();
            }
            return result;
        }
    }
}
