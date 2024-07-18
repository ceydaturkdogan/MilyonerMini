using System;

namespace MilyonerMini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster?");

            Console.WriteLine("Soru 1-) Kızınca tüküren hayvan hangisidir ?\na-)Lama b-)Deve");


            string firstAnswer = Console.ReadLine().ToLower();

            if (firstAnswer == "a")
            {
                Console.WriteLine("Doğru Cevap! 2. soruya geçelim");

            }
            else
            {
                Console.WriteLine("Yanlış Cevap ! 2.soruya geçelim");

            }

            Console.WriteLine("Soru 2-) Dünya'ya en yakın gezegen hangisidir  ?\na-)Venüs b-)Mars");
            string secondAnswer = Console.ReadLine().ToLower();
            if (firstAnswer == "a" && secondAnswer == "b") //her iki sorunun doğru olduğu conditionu inceler
            {
                Console.WriteLine("Doğru cevap ! 1 Milyon TL kazandınız !!"); //iki doğru olduğu için diğerlerine geçmez.

            }
            else if (firstAnswer == "a" && secondAnswer == "a") { //ilk sorunun yanlış ikinci sorunun doğru olduğu conditionu inceler
                
                Console.WriteLine("Yanlış Cevap ! 3.soruya geçelim");
                Console.WriteLine("Soru 3-)  5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?  \na-)7 b-)12");
                string thirdAnswer = Console.ReadLine().ToLower();
                if (thirdAnswer == "b")
                {

                    Console.WriteLine("Doğru cevap ! 1 Milyon TL kazandınız !!");

                }
                else
                {
                    Console.WriteLine("Elendiniz");
                }
            }
            else if (firstAnswer == "b" && secondAnswer == "b") //ilk sorunun doğru ikinci sorunun yanlış olduğu durumu inceler
            {

                Console.WriteLine("Doğru Cevap ! 3.soruya geçelim");
                Console.WriteLine("Soru 3-)  5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?  \na-)7 b-)12");
                string thirdAnswer = Console.ReadLine().ToLower();
                if (thirdAnswer == "b")
                {
                    Console.WriteLine("Doğru cevap ! 1 Milyon TL kazandınız !!");

                }
                else
                {
                    Console.WriteLine("Elendiniz"); 
                }
            }

        }
    }
}