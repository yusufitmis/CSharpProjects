using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<Question> sorular = new List<Question>
            {
                new Question
                {
                    soruMetni = "En Popüler Programlama Dili Hangisidir?" ,
                    secenekler =new string[]{"a) Python","b) C#","c) Java","d) Php"},
                    _cevap = "Python"
                    
                },
                new Question
                {
                    soruMetni = "En İyi Programlama Dili Hangisidir?" ,
                    secenekler =new string[]{"a) Python","b) C#","c) Java","d) Php"},
                    _cevap = "C#"

                },
                new Question
                {
                    soruMetni = "Echo Hangi Dilde Vardır??" ,
                    secenekler =new string[]{"a) Python","b) C#", "c) Java", "d) Php"},
                    _cevap = "Php"

                }

            };
            var puan = 0;
            foreach (var soru in sorular)
            {
                Console.WriteLine(soru.soruMetni);
                foreach (var secenek in soru.secenekler)
                {
                    Console.WriteLine(" "+secenek);
                }
                Console.Write("Cevabınızı Girin: ");
                var cevap = Console.ReadLine();
                if (soru.cevapKontrol(cevap))
                {
                    Console.WriteLine("doğru");
                    puan += 10;
                }
                else Console.WriteLine("yanlış");
                Console.WriteLine("---------------------");


            }
            Console.WriteLine("Puan: " + puan);

        }
    }
    class Question
    {
        public string soruMetni { get; set; }
        public string _cevap { get; set; }
        public  string[] secenekler { get; set; }
        public bool cevapKontrol(string cevap)
        {
            if (this._cevap.ToUpper() == cevap.ToUpper())
            {
                return true;
            }
            else return false;
        }


    }
}
