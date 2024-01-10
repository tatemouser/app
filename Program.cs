using System;
using System.IO.Pipes;
using System.Numerics;

// Project Concept: UNO

/* Program Order:
 * 
 *
 * Game Constraints:
 * CARDS - 108 total cards - 25 cards for each color / red : 1 0 card, 2 1-9 cards, 2 +2 cards, 2 skip cards, 2 reverse cards / 4 +4 cards, 4 wild cards
 * LOGIC - 2-10 players, 7 cards each, 1 card in discard pile
 * ORDER - Go in "circle", if(canPlay) play! else drawCard, to next, while(playersNumOfCards > 0)
*/

class Program {
     public static bool checkCanStillPlay() {
          return true;
     }






     public static void Main(string[] args) {
          bool playing = true;

          while (playing) {
               bool canStillPlay = true;
               Console.WriteLine("Let's play UNO!");
               

               string stdinInput = string.Empty;
               int numOfPlayers = 0;

               while (numOfPlayers < 2 || numOfPlayers > 10) {
                    Console.WriteLine("Type the number of people you would like to play with! (2-10)");
                    stdinInput = Console.ReadLine() ?? string.Empty;
                    numOfPlayers = (int.TryParse(stdinInput, out numOfPlayers)) ? numOfPlayers : 0;
               }



               // TODO: REMOVE BELOW
               UnoPlayer player1 = new UnoPlayer(1);
               player1.Cards.Add(new UnoCard("Red", 3));
               player1.Cards.Add(new UnoCard("Blue", 5));
               // Retrieve information later
               int playerIndex = player1.PlayerIndex;
               List<UnoCard> player1Cards = player1.Cards;
               Console.WriteLine("Player " + playerIndex + " has " + player1Cards.Count + " cards.");
               // TODO: REMOVE ABOVE
                




                /* Actual Game Loop */

                // Player starts game as index 0
               int turnIndex = 0; 
               // Decide who goes -> They play -> Check Game Status -> Next Player Goes
               while (canStillPlay) {
                    // if(playersTurn) ask and show player cards ect / else do robot turns and announce what they did
                    if(turnIndex != 0) {
                         // Robot turn
                    } else {
                         // User turn
                    }

                    // Every player has >1 cards
                    canStillPlay = checkCanStillPlay();

                    turnIndex = (turnIndex == numOfPlayers - 1) ? 0 : turnIndex + 1;
               }








               // To end or restart the game
               while (stdinInput != "y" && stdinInput != "n") {
                    Console.WriteLine("Would you like to play again? (y/n)");
                    stdinInput = Console.ReadLine() ?? string.Empty;
               }
          
               if (stdinInput == "n") {
                    playing = false;
                    Console.WriteLine("Goodbye World!");
               }
          }
     }
}

