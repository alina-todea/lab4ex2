using System;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)

        {
            

            /*
          Scrieti un program care va modela un autoturism.
Un autoturism va avea o marca (string), un numar de inmatriculare (string),
precum si o capacitate cilindrica(int).
Autoturismul va avea:
 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “GetDescription” care va returna descrierea acestuia sub forma :
 “marca, numarDeInmatriculare, capacitateCilindrica”.
Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii xml pentru metodele publice.
Creeati doua obiecte de tipul autoturism in functia “Main” apelati-le metodele si afisati rezultatul.
             */


            autoturism Ford = new autoturism("Ford", "CJ03 123", 1600);
            autoturism Audi = new autoturism("Audi", "CJ01 456", 1800);

            Console.WriteLine($"Primul autoturism:\t{Ford.GetDescription(Ford.GetMarca(), Ford.GetNumarInmatriculare(), Ford.GetCapacitateCilindrica())}");
            Console.WriteLine($"Al doilea  autoturism:\t{Audi.GetDescription(Ford.GetMarca(), Audi.GetNumarInmatriculare(), Audi.GetCapacitateCilindrica())}");
           

        }


        


        class autoturism
        {

            private string marca;
            private string numarInmatriculare;
            private int capacitateCilindrica;



            public autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
            {

                this.marca = marca;
                this.numarInmatriculare = numarInmatriculare;
                this.capacitateCilindrica = capacitateCilindrica;
            }

            /// <summary>
            /// returneaza marca
            /// </summary>
            /// <returns></returns>
            public string GetMarca()
            {
                return marca;
            }

            /// <summary>
            /// returneaza nr de inmatriculare
            /// </summary>
            /// <returns></returns>
            public string GetNumarInmatriculare()
            {
                return numarInmatriculare;
            }

            /// <summary>
            /// returneaza capacitatea cilindrica
            /// </summary>
            /// <returns></returns>
            public int GetCapacitateCilindrica()
            {
                return capacitateCilindrica;
            }

            /// <summary>
            /// returneaza descrierea incluzand marca, nr de inmatriculare, capacitatea cilindrica
            /// </summary>
            /// <param name="marca"></param>
            /// <param name="numarInmatriculare"></param>
            /// <param name="capacitateCilindrica"></param>
            /// <returns></returns>
            public string GetDescription(string marca, string numarInmatriculare, int capacitateCilindrica)
            { 
                ;

                return GetMarca() + ", " + GetNumarInmatriculare() + ", " + GetCapacitateCilindrica();
            }



        }
    }
}
