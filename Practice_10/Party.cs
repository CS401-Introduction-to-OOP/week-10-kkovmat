using System.Collections;
namespace Practice_10;
class Party : IEnumerable<Character>
{
    private List<Character> characters = new List<Character>();

   
    public Party()
    {
        
    }
    public Party(List<Character> characters)
    {
        this.characters = new List<Character>(characters);
    }

    public void AddCharacter(Character character)
    {
        characters.Add(character);
    }

    public List<Character> GetActiveCharacters()
    {
        return characters.Where(ch => ch.Status=="active").ToList();
        
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach(var character in characters)
        {
            yield return character;
        }
    }
    IEnumerator<Character> IEnumerable<Character>.GetEnumerator()
    {
       return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<Character> GetActiveCharacter()
    {
        foreach(var ch in characters)
        {
            if (ch.Status == "active")
            {
                yield return ch;    
            }
            
        }
    }

    public IEnumerator<Character> GetByHP(int hp)
    {
        foreach(var ch in characters)
        {
            if (ch.HP < hp)
            {
                yield return ch;    
            }
            
        }
    }
}