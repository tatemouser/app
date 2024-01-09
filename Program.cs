using System;

// Project Concept: UNO

/* Program Order:
 * 
 *
 * Game Constraints:
 * 108 total cards - 25 cards for each color
 * red : 1 0 card, 2 1-9 cards, 2 +2 cards, 2 skip cards, 2 reverse cards
 * 4 +4 cards, 4 wild cards
*/

class Program {
     public static void Main(string[] args) {
          bool playing = true;

          while (playing) {
               bool canStillPlay = true;

               Console.WriteLine("Let's play UNO!");
               Console.WriteLine("Press Enter to continue...");
               string input = Console.ReadLine() ?? string.Empty;



               /* 
                * Game running within this loop
                */
               while (canStillPlay) {
                    break;
               }



               while (input != "y" && input != "n") {
                    Console.WriteLine("Would you like to play again? (y/n)");
                    input = Console.ReadLine() ?? string.Empty;
               }

               if (input == "y") {
                    playing = true;
               } else if (input == "n") {
                    playing = false;
                    Console.WriteLine("Goodbye World!");
               }
          }
     }
}

