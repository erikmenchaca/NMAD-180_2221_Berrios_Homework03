public class Player
{
    private string playername;
    private int playernumber;
    private string playerposition;

    public const int MIN_JERSEY_NUMBER = 0;
    public const int MAX_JERSEY_NUMBER = 99;
    public string PlayerName
    {
        set
        {
            if (value != null && value != "")
            {
                playername = value;
            }
        }
        get
        {
            if (playername == null || playername == "")
                return "The player's name is not assigned";

            return playername;
        }
    }
    public bool PlayerNameIsValid
    {
        get
        {
            if (playername == null || playername == "")
                return false;
            return true;
        }
    }
    public int PlayerNumber
    {
        set
        {
            if (value >= MIN_JERSEY_NUMBER && value <= MAX_JERSEY_NUMBER)
                playernumber = value;
        }
        get
        {
            return playernumber;
        }
    }
    public bool PlayerNumberIsValid
    {
        get
        {
            return playernumber >= MIN_JERSEY_NUMBER && playernumber <= MAX_JERSEY_NUMBER;
        }
    }
    public string PlayerPosition
    {
        set
        {
            if (value != null && value != "")
                playerposition = value;
        }
        get
        {
            return playerposition;
        }
    }
    public bool PlayerPositionIsValid
    {
        get
        {
            if (playerposition == null || playerposition == "")
                return false;
            return true;
        }
    }

    public Player() { }

    public Player(string playername, int playernumber, string playerposition)
    {
        PlayerName = playername;
        PlayerNumber = playernumber;
        PlayerPosition = playerposition;
    }
    public override string ToString()
    {
        return $"Name: {PlayerName}\nPlayer's jersey number: {PlayerNumber}\nPlayer's playing position: {PlayerPosition} ";
    }
}