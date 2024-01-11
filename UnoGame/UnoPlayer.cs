public class UnoPlayer {
    public int PlayerIndex { get; }
    public List<UnoCard> Cards { get; }

    public UnoPlayer(int playerIndex) {
        PlayerIndex = playerIndex;
        Cards = new List<UnoCard>();
    }
}

