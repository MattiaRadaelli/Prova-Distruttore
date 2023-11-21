using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Distruttore
{
    class Esempio
    {
        protected string _stringa;
        protected int _numero;
        public Esempio()
        {
            _stringa = "Casa Ciuca";
            _numero = 2;
        }
        public void Stampa()
        {
            Console.WriteLine($"{_stringa} è il numero {_numero}");
        }

        ~Esempio()
        {
            Console.WriteLine("Casa Ciuca (numero 2) è stato distrutta");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Esempio esempio = new Esempio();
            esempio.Stampa();
        }
    }
}
