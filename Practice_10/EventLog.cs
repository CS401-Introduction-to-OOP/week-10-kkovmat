using System.Collections;
namespace Practice_10;
class EventLog : IEnumerable<Event>
{
    private List<Event> events = new List<Event>();

    public EventLog()
    {
        
    }
    public EventLog(List<Event> events)
    {
        this.events = new List<Event>(events);
    }

    public void AddEvent(Event ev)
    {
        events.Add(ev);
    }
    public List<Event> EventChronology() 
    {
        return events.OrderBy(ev => ev.Move).ToList();
            
    }

    public IEnumerator<Event> GetEnumerator()
    {
        foreach(var ev in events)
        {
            yield return ev;
        }
    }
    IEnumerator<Event> IEnumerable<Event>.GetEnumerator()
    {
       return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}