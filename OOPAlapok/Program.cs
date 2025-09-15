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

        public override string ToString()
        {
            return $"A személy neve {_nev} és az életkora {_kor}";
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

    public class Bankszamla
    {
        private int _egyeneleg;

        public int Egyenleg
        {
            get { return _egyeneleg; }
            set
            {
                if (value > 0)
                    _egyeneleg = value;
                else
                    Console.WriteLine("Egyenleg nem lehet nulla!");
            }
        }
        public void Betesz()
        {

        }

        public void Kivesz()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Nev = "Kiss Ilona";
            person.Kor = 23;
            Console.WriteLine(person);

            /*Szemely person = new Szemely("Ilona", 44);
            System.Console.WriteLine(person.Kiir());*/

        }
    }
}
