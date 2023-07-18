using System;
namespace lab4ex2
{



    class Autoturism
    {

        private string marca;
        private string numarInmatriculare;
        private int capacitateCilindrica;



        public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
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