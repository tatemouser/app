public class UnoPlayer {
    public int PlayerIndex { get; }
    public List<UnoCard> Cards { get; }

    public UnoPlayer(int playerIndex) {
        PlayerIndex = playerIndex;
        Cards = new List<UnoCard>();
    }
}

public class UnoCard {
    public string Color { get; }
    public int Number { get; }

    public UnoCard(string color, int number) {
        Color = color;
        Number = number;
    }
}
