using System;

namespace WorkInClass_01._26._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bicycle bc = new Bicycle();
            //bc.Drive(5);
            //bc.Drive(6);
            //Console.WriteLine(bc.Millage);

            #region MyRegion
            Bicycle[] bcs = new Bicycle[3];
            for (int i = 0; i < bcs.Length; i++)
            {
                string brand;
                bool isOk = false;
                do
                {
                    if (isOk==true)
                    {
                        Console.WriteLine("Brand adi boyuk herfle ve ya reqemle baslamalidi");
                    }
                    Console.Write("Brand : ");
                     brand = Console.ReadLine();
                    isOk = true;
                } while (string.IsNullOrWhiteSpace(brand));

                string model;
                bool isOk2=false;
                do
                {
                    if (isOk2 == true)
                    {
                        Console.WriteLine("Model adi boyuk herfle ve ya reqemle baslamalidi");
                    }
                    Console.Write("Model : ");
                     model = Console.ReadLine();
                    isOk2 = true;
                } while (string.IsNullOrWhiteSpace(model));


                Bicycle bc = new Bicycle(brand, model);

                bcs[i] = bc;

            }
            string option;
            do
            {

                Console.WriteLine("1. Butun velosipedlere bax");
                Console.WriteLine("2.Velosipedlr arasinda model adina gore axtaris et");

                Console.WriteLine("Emeliyati secin");
                 option = Console.ReadLine();
                switch (option)
                {

                    case "1":
                        for (int i = 0; i < bcs.Length; i++)
                        {
                            Console.WriteLine($"Brand : {bcs[i].Brand}\nModel : {bcs[i].Model}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Modeli daxil edin :");
                        string model = Console.ReadLine();
                        for (int i = 0; i < bcs.Length; i++)
                        {
                            if (bcs[i].Model.Contains(model))
                            {
                                Console.WriteLine($"Brand : {bcs[i].Brand} - Model : {bcs[i].Model} - Price : {bcs[i].Millage}");
                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine("Emeliyyat dayandirildi");
                        break;
                }

            } while (option !="0");




            #endregion


        }
    }
}




