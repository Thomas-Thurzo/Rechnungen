using Nito.Collections;
using System;
using System.Linq;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rechnungen = { 10, 20, 70, 20, 50, 34, 18 };
            int gesamtBetrag = 70;
            Deque<int> liste = new Deque<int>();
            findePotenzMenge(rechnungen, liste, rechnungen.Length, gesamtBetrag);
        }

        public static void findePotenzMenge(int[] rechnungen, Deque<int> liste, int n, int gesamtBetrag)
        {
            if (n == 0)
            {
                if (liste.Sum() == gesamtBetrag){
                    foreach(int i in liste)
                    {
                        Console.WriteLine(i);                       
                    }
                    Console.ReadLine();
                }

                return;
            }

            liste.AddToBack(rechnungen[n - 1]);
            findePotenzMenge(rechnungen, liste, n - 1, gesamtBetrag);
            liste.RemoveFromBack();

            findePotenzMenge(rechnungen, liste, n - 1, gesamtBetrag);
        }
    }

}
