using System;

namespace quizzpop
{
    class Program
    {
        //Perguntas

        public static string Questão1 = "Quem foi a drag vencedora da 10 temporada de Rupaul's Drag Racce?";
        public static string Questão2 = "Quem foi a escritora do livro Frankenstein?";
        public static string Questão3 = "Qual o single do último comeback do grupo BTS?";
        public static string Questão4 = "Qual sailor é a protagonista do anime Sailor Moon?";
        public static string Questão5 = "Quem é o roteirista e compositor do musical Hamilton?";

        //Acertos
        public static sbyte Acertos = 0;
        static void Main(string[] args)
        {
            Console.ReadLine();
            Questões();
            Resultado();
           
        }
    
        public static void Questões()
        {
            //Q1
            Console.WriteLine(Questão1);
            Questão1 = Console.ReadLine();
            if (Questão1 == "Aquaria")
            {
                Console.WriteLine("Resposta certa");
                Acertos++;
            }
            else
            {
                Console.WriteLine("Resposta errada");
            }

            //Q2
            Console.WriteLine(Questão2);
            Questão2 = Console.ReadLine();
            if (Questão2 == "Mary Shelley")
            {
                Console.WriteLine("Resposta certa");
                Acertos++;
            }
            else
            {
                Console.WriteLine("Resporta errada");
            }

            //Q3
            Console.WriteLine(Questão3);
            Questão3 = Console.ReadLine();
            if (Questão3 == "Dynamite")
            {
                Console.WriteLine("Resposta certa");
                Acertos++;
            }
            else
            {
                Console.WriteLine("Resporta errada");
            }

            //Q4
            Console.WriteLine(Questão4);
            Questão4 = Console.ReadLine();
            if (Questão4 == "Sailor Moon")
            {
                Console.WriteLine("Resposta certa");
                Acertos++;
            }
            else
            {
                Console.WriteLine("Resporta errada");
            }

            //Q5
            Console.WriteLine(Questão5);
            Questão5 = Console.ReadLine();
            if (Questão5 == "Lin-Manuel Miranda")
            {
                Console.WriteLine("Resposta certa");
                Acertos++;
            }
            else
            {
                Console.WriteLine("Resporta errada");
            }




        }

        public static void Resultado()
        {
            if (Acertos == 0)
            {
                Console.WriteLine("Não houveram acertos");
            }

            else if (Acertos == 1)
            {
                Console.WriteLine("Você acertou 1 questão");
            }

            else if (Acertos == 2)
            {
                Console.WriteLine("Você acertou 2 questões");
            }

            else if (Acertos == 3)
            {
                Console.WriteLine("Você acertou 3 questões");
            }

            else if (Acertos == 4)
            {
                Console.WriteLine("Você acertou 4 questões");
            }

            else if (Acertos == 5)
            {
                Console.WriteLine("Você acertou 5 questões");
            }



        }






    }
}
