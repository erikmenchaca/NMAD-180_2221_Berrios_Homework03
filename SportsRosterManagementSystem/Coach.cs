public class Coach
{
    private string coachname, coachposition;

    public string CoachName
    {
        set
        {
            if (value != null && value != "")
            {
                coachname = value;
            }
        }
        get
        {
            if (coachname == null || coachname == "")
                return "Coach's name is not assigned";
            return coachname;
        }
    }
    public bool CoachNameIsValid
    {
        get
        {
            if (coachname == null || coachname == "")
                return false;

            return true;
        }
    }
    public string CoachPosition
    {
        set
        {
            if (value != null && value != "")
                coachposition = value;
        }
        get
        {
            if (coachposition == null || coachposition == "")
                return "The coach's position is not assigned";

            return coachposition;
        }
    }
    public bool CoachPositionIsValid
    {
        get
        {
            if (coachposition == null || coachposition == "")
                return false;
            
            return true;
        }
    }
    
    public override string ToString()
    {
        return $"Coach's name: {CoachName}\nCoach's position: {CoachPosition}";
    }
}