using System;
using System.Collections.Generic;
//using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBeispiel_Do1 {
    class Program {
        static void Main ( string [ ] args ) {

            // Warteschlange = Queue
            Queue<string> warteschlange = new Queue<string>();  // Instanziierung
            warteschlange.Enqueue ( "Moro" );
            warteschlange.Enqueue ( "Alex" );
            warteschlange.Enqueue ( "Robert" );
            warteschlange.Enqueue
                ( "Rahaf" );

            Console.WriteLine ( warteschlange.Peek());

            string MoroRettung = warteschlange.Dequeue ( );
            Console.WriteLine ( "Gerettet {0}", MoroRettung);

            // Stapel = Stack
            Stack<string> meinStapel = new Stack<string> ( );  // Instanziierung
            meinStapel.Push ( "Philipp" );
            meinStapel.Push ( "Selim" );
            meinStapel.Push ( "Julia" );

            Console.WriteLine ( meinStapel.Peek());

            // ======================= Western ==========================
            // Erstelle Steckbrief
            Steckbrief sven = new Steckbrief ( ) { Name = "Der Sven" , Kopfgeld = 1 , Lebendig = true };
            Steckbrief sven2 = new Steckbrief ( ) { Name = "Der tänzelnde Sven" , Kopfgeld = 1000 , Lebendig = true };
            Steckbrief sven3 = new Steckbrief ( ) { Name = "Der singende Sven" , Kopfgeld = -1000 , Lebendig = false };

            Stack<Steckbrief> SchreibtischStapel = new Stack<Steckbrief> ( );
            SchreibtischStapel.Push ( sven);
            SchreibtischStapel.Push ( sven2);
            SchreibtischStapel.Push ( sven3);

            foreach ( Steckbrief steckbrief in SchreibtischStapel ) {
                Console.WriteLine ( "Name: {0} Euro: {1} Lebend: {2}", steckbrief.Name , steckbrief.Kopfgeld , steckbrief.Lebendig );
            }
            Console.WriteLine ( "=====");
            SchreibtischStapel.Pop ( );

            foreach ( Steckbrief steckbrief in SchreibtischStapel ) {
                Console.WriteLine ( "Name: {0} Euro: {1} Lebend: {2}" , steckbrief.Name , steckbrief.Kopfgeld , steckbrief.Lebendig );
            }

            Console.ReadLine ( );
        }
    }

    public class Steckbrief {
        public string Name { get; set; }
        public int Kopfgeld { get; set; }
        public bool Lebendig { get; set; }
    }
}
