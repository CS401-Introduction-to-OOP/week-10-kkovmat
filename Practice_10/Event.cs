namespace Practice_10;
class Event
{
    public int Move
    {
        get;
        private set;
    }

    public string Description
    {
        get;
        private set;
    }

    public string Type
    {
        get;
        private set;
    }

    public string? CharacteristicsChanges
    {
        get;
        private set;
    }

    public Event(int move, string type, string description="", string? characteristicsChanges=null) 
    {
        Move = move;
        Type = type;
        Description = description;
        CharacteristicsChanges = characteristicsChanges;
    }

    public override string ToString()
    {
        return $"{Move} {Type}";
    }
}