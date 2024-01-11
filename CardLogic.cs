using System;
public class CardLogic {
    private List<UnoCard> cards;
    public CardLogic() {
        cards = new List<UnoCard>();
    }

    private void setDeck(List<UnoCard> cards) {
        this.cards = cards;
    }

    public List<UnoCard> getDeck() {
        return cards;
    }




    /*
    * Creates a new deck of UnoCards   
    * @return deck - list of UnoCards
    */
    private List<UnoCard> getNewDeck() {
        List<UnoCard> deck = new List<UnoCard>();
        string[] colors = { "Red", "Blue", "Green", "Yellow" };
        string[] values = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        foreach (string color in colors) {
            deck.Add(new UnoCard(color, "0"));

            foreach (string value in values) {
                deck.Add(new UnoCard(color, value));
                deck.Add(new UnoCard(color, value));
            }

            for (int i = 0; i < 2; i++) {
                deck.Add(new UnoCard(color, "Skip"));
                deck.Add(new UnoCard(color, "Reverse"));
                deck.Add(new UnoCard(color, "+2"));
            }
        }

        for (int i = 0; i < 4; i++) {
            deck.Add(new UnoCard("Wild", "Wild"));
            deck.Add(new UnoCard("Wild", "+4"));
        }
        
        // SHUFFLE 
        Random random = new Random();
        int n = deck.Count;

        for (int i = n - 1; i > 0; i--) {
            int j = random.Next(0, i + 1);
            UnoCard temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }

        return deck;
    }

    /*
    * Takes remaining cards not dealt, assigns to public deck variable
    * @return players - list of players with 7 cards each
    */
    public List<UnoPlayer> PassOut7Cards(int numOfPlayers) {

        List<UnoPlayer> players = new List<UnoPlayer>();
        List<UnoCard> cards = getNewDeck();

        for(int i = 0; i < numOfPlayers; i++) {
            UnoPlayer player = new UnoPlayer(i);
            for(int j = 0; j < 7; j++) {
                player.Cards.Add(cards[0]);
                cards.RemoveAt(0);
            }
            players.Add(player);
        }
        setDeck(cards);
        return players;
    }


    public bool canPlay(UnoCard currCard, List<UnoCard> cards) {
        return true;
    }
}


