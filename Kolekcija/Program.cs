using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija
{
    internal class Program
    {
        class Klasa
        {
            int godina;
            string ime, prezime;

            public Klasa(int godina, string prezime)
            {
                this.godina = godina;
                this.prezime = prezime;
            }

            public int Godina { get => godina; set => godina = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string Ime { get => ime; set => ime = value; }

            public override string ToString()
            {
                string ispis = "Godina: "+ Godina+",Ime: "+Ime+", Prezime: "+Prezime+".";
                return ispis;
            }

        }
        static void Main(string[] args)
        {/*
            //Definiranje ArrayList kolekcije
            ArrayList al = new ArrayList();

            //Dummy varijable i objekt
            int broj = 1;
            string ime = "Ime";
            bool provjera = false;
            Klasa klasa = new Klasa(2023, "Prezime");
            
            //Dodavanje elemnt u ArrayList-u
            al.Add(klasa);
            al.Add(provjera);
            al.Add(broj);
            al.Add(ime);

            //Ispis Elemenata
            Console.WriteLine("---- Ispis svih elemenata ---");
            for(int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.RemoveAt(2);

            Console.WriteLine("\n\n---- Ispis svih elemenata nakon remove ---");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.Insert(2, broj);

            Console.WriteLine("\n\n---- Ispis svih elemenata nakon insert ---");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }*/

            List<Klasa> listObjekata = new List<Klasa>();

            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Unesi godinu: ");
                int godinaO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesi prezime: ");
                string prezimeO = Console.ReadLine();
                Klasa objekt = new Klasa(godinaO,prezimeO);
                listObjekata.Add(objekt);
                Console.WriteLine("");
            }
            /*for(int i = 0; i < listObjekata.Count; i++)
            {
                Console.WriteLine(listObjekata[i]);
            }*/
            foreach(Klasa o in listObjekata)
            {
                if (o.Godina < 2023)
                {
                    o.Ime = "Gabriel";
                    Console.WriteLine(o.Prezime);
                    Console.WriteLine(o.Ime);
                    Console.WriteLine("");
                }
            }

            Console.ReadLine();
        }
    }
}
