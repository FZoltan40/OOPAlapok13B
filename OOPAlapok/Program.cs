using System;
using System.Collections.Generic;

namespace OOPAlapok
{
    public class Szemely
    {
        protected string _nev;
        private int _kor;

        public Szemely(string nev, int kor)
        {
            _nev = nev;
            Kor = kor;
        }
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

        public Hallgato(string nev, int kor, string neptunkod) : base(nev, kor)
        {
            _neptunkod = neptunkod;
        }
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

            return $"A hallgato neve {_nev} életkora {Kor} neptunkódja {_neptunkod}";
        }

    }
    public class Dolgozo : Szemely
    {
        private int _ber;

        public Dolgozo(string nev, int kor, int ber) : base(nev, kor)
        {
            _ber = ber;
        }

        public override string ToString()
        {
            return $"A hallgato neve {_nev} életkora {Kor} neptunkódja {_ber}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Szemely person = new Szemely("Kiss Ilona", 23);
            Console.WriteLine(person);*/

            Hallgato student = new Hallgato("Kiss Gábor", 33, "neptun1");
            Console.WriteLine(student);

            Dolgozo worker = new Dolgozo("Toth Gábor", 25, 33000);
            Console.WriteLine(worker);

            List<Hallgato> studentList = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {

                Console.Write($"Kérem a(z) {i + 1} hallgató nevét:");
                string nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát:");
                int kor = int.Parse(Console.ReadLine());
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát:");
                string neptun = Console.ReadLine();
                Hallgato std = new Hallgato(nev, kor, neptun);
                studentList.Add(std);

            }

            foreach (var item in studentList)
            {
                Console.WriteLine(item.Nev);
            }

            //Dolgozo worker = new Dolgozo();
            //Console.WriteLine(worker);

            /*Szemely person = new Szemely("Ilona", 44);
            System.Console.WriteLine(person.Kiir());*/

        }
    }
}
