namespace Practice_10;
class Program
{
    static void Main()
    {
        Console.WriteLine("Character test");

        Character character1 = new Character("name1", "warior");
        Character character2 = new Character("name2", "qwerty");
        Character character3 = new Character("name3", "dragon");
        character1.ActivateCharacter();
        Party party1 = new Party();
        party1.AddCharacter(character1);
        party1.AddCharacter(character2);
        party1.AddCharacter(character3);

        foreach(var ch in party1)
        {
            Console.WriteLine(ch);
        }
        foreach(var ch in party1.GetActiveCharacters())
        {
            Console.WriteLine(ch);
        }


        Console.WriteLine("Event test");

        Event event1 = new Event(2, "ordinary");
        Event event2 = new Event(1, "hp");
        Event event3 = new Event(4, "gold");
        EventLog events = new EventLog();
        events.AddEvent(event1);
        events.AddEvent(event2);
        events.AddEvent(event3);
        
        foreach(var ev in events)
        {
            Console.WriteLine(ev);
        }

        foreach(var ev in events.EventChronology())
        {
            Console.WriteLine(ev);
        }
    }
}