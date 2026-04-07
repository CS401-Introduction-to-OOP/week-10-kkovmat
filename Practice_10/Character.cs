namespace Practice_10;
class Character
{
    public string Name
    {
        get => field;
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be empty.");
            }
            field = value;
        }
    }

    public string Role 
    {
        get;
        private set;
    }

    public int Level
    {
        get;
        private set;
    }

    public int HP
    {
        get;
        private set;
    }

    public int Gold
    {
        get;
        private set;
    }

    public string Status
    {
        get;
        private set;
    }

    public Character(string name, string role, int level=1, int hp=100, int gold=0, string status="unknown")
    {
        Name = name;
        Role = role;
        Level = level;
        HP = hp;
        Gold = gold;
        Status = status;
    }

    public void ActivateCharacter()
    {
        Status = "active";
    }
    public void DeactivateCharacter()
    {
        Status = "deactive";
    }

    public override string ToString()
    {
        return $"{Role} {Name}";
    }
}