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
          // Loops til player says to stop program.
          while (playing) {
               bool canStillPlay = true;
               Console.WriteLine("Let's play UNO!");


               // GET NUM OF PLAYERS               
               string stdinInput = string.Empty;
               int numOfPlayers = 0;

               while (numOfPlayers < 2 || numOfPlayers > 10) {
                    Console.WriteLine("How many people are playing! (2-10)");
                    stdinInput = Console.ReadLine() ?? string.Empty;
                    numOfPlayers = (int.TryParse(stdinInput, out numOfPlayers)) ? numOfPlayers : 0;
               }

               // HANDLE AND SET CARDS
               CardLogic handleCards = new CardLogic();
               List<UnoPlayer> currPlayers = handleCards.PassOut7Cards(numOfPlayers);
               for(int i = 0; i < numOfPlayers; i++) {
                    Console.WriteLine("Player " + i + " has " + currPlayers[i].Cards.Count + " cards.");
               }
               for(int i = 0; i < 7; i++) {
                    Console.Write(currPlayers[0].Cards[i].Color + " " + currPlayers[0].Cards[i].Type + " | ");
                    Console.Write(currPlayers[1].Cards[i].Color + " " + currPlayers[1].Cards[i].Type + " | ");
                    Console.Write(currPlayers[2].Cards[i].Color + " " + currPlayers[2].Cards[i].Type + " | ");
                    Console.WriteLine();
               }
  






               // // TODO: REMOVE BELOW
               // UnoPlayer player1 = new UnoPlayer(0);
               // player1.Cards.Add(new UnoCard("Red", "3"));
               // player1.Cards.Add(new UnoCard("Blue", "5"));

               // currPlayers.Add(player1);
               // Console.WriteLine(currPlayers[0].Cards[0].Color);

               // // Retrieve information later
               // int playerIndex = player1.PlayerIndex;
               // List<UnoCard> player1Cards = player1.Cards;
               // Console.WriteLine("Player " + playerIndex + " has " + player1Cards.Count + " cards.");
               // // TODO: REMOVE ABOVE
                




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

