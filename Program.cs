using System;
using lab4ex2;

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


            Autoturism Ford = new Autoturism("Ford", "CJ03 123", 1600);
            Autoturism Audi = new Autoturism("Audi", "CJ01 456", 1800);

            Console.WriteLine($"Primul autoturism:\t{Ford.GetDescription(Ford.GetMarca(), Ford.GetNumarInmatriculare(), Ford.GetCapacitateCilindrica())}");
            Console.WriteLine($"Al doilea  autoturism:\t{Audi.GetDescription(Ford.GetMarca(), Audi.GetNumarInmatriculare(), Audi.GetCapacitateCilindrica())}");
           

        }


    }
}

