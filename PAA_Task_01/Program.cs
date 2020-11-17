using System;

namespace PAA_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Coins; // Кол-во монет
            const int priceCrystals = 9; // цена одного кристалла
            int buyCrystals; // сколько пользователь хочет купить кристаллов
            bool optionPurchase; // опция покупки

            Console.Write("Сколько у вас монет? - ");
            Coins = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Цена кристалла {priceCrystals} монет. Сколько вы хотите купить кристаллов? - ");
            buyCrystals = Convert.ToInt32(Console.ReadLine());

            optionPurchase = Coins >= priceCrystals * buyCrystals;
            buyCrystals *= Convert.ToInt32(optionPurchase);
            Coins -= priceCrystals * buyCrystals;

            Console.WriteLine($"У вас осталось {Coins} монет(-ы) и появилось {buyCrystals} кристалл(-а)(-ов).");
        }
    }
}
