using System;
using System.Collections.Generic;

namespace OOPAlapok
{
    public class Szemely
    {
        protected string _nev;
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

    public class Hallgato : Szemely
    {
        private string _neptunkod;

        public string Neptunkod
        {
            get { return _neptunkod; }
            set
            {
                if (_neptunkod.Length <= 6)
                    _neptunkod = value;
                else
                    Console.WriteLine("Túl hosszú kód!");
            }
        }
        public override string ToString()
        {
            _nev = "Gábor";
            return $"A hallgato neve {_nev}";
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

            Hallgato student1 = new Hallgato();
            Console.WriteLine(student1);

            List<Hallgato> studentList = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {
                Hallgato student2 = new Hallgato();
                Console.Write($"Kérem a(z) {i + 1} hallgató nevét:");
                student2.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát:");
                student2.Kor = int.Parse(Console.ReadLine());
                studentList.Add(student2);

            }

            foreach (var item in studentList)
            {
                Console.WriteLine(item.Nev);
            }

            /*Szemely person = new Szemely("Ilona", 44);
            System.Console.WriteLine(person.Kiir());*/

        }
    }
}
