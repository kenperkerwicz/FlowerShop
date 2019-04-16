using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
           FlowerShop GoldenrodFlower = new FlowerShop();

           GoldenrodFlower.MakeMothersDayArrangement().ForEach(flower => Console.WriteLine($" the size of this flower is {flower.Size} inches and the flower is {flower}"));

       GoldenrodFlower.MakeBirthdayArrangement().ForEach(flower => Console.WriteLine($" the size of this flower is {flower.Size} inches and the flower is {flower}"));


        }
    }
}
