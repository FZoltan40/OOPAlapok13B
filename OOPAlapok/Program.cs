using System;

namespace OOPAlapok
{
    public class Szemely
    {
        private string _nev;
        private int _kor;

        public string Nev
        {
            get { return _nev; } //private adattag kiolvasásához
            set { _nev = value; } // private adattag beállításához
        }

        public int Kor
        {
            get { return _kor; }

            set
            {
                if (value > 0)
                    _kor = value;
                else
                    Console.WriteLine("Nem lehet negatív.");
            }
        }

        /*public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }*/

        /*public string Kiir()
        {
            return $"A személy neve: {nev} és életkora: {kor}";
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Nev = "Kiss Ilona";
            person.Kor = 23;
            Console.WriteLine($"A személy neve: {person.Nev} és {person.Kor} éves.");

            /*Szemely person = new Szemely("Ilona", 44);
            System.Console.WriteLine(person.Kiir());*/

        }
    }
}
