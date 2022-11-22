public class Player
{
    private string name;
    private int number;
    private string position;

    public string Name
    {
        set {
            if (value != null && value != "")
            {
                name = value;
            }
        }
        get
        {
            if(name == null || name == "")
            {
                return "Name is not valid.";
                return name;
            }
        }
    }
    public Player() { }

    public Player(string name, int number, string position)
    {
        Name = name;
        Number = number;
        Position = position;
    }
}