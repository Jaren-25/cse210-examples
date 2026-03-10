using System;

public class Program
{
    public static void Main(string[] args)
    {
        OrganStopConsole console = new OrganStopConsole();
        
        PipeOrgan pipe = new PipeOrgan("Main Pipe");
        pipe.SetNote("Low C");
        pipe.SetIsOn(true);
        console.AddComponent(pipe);

        PercussionShelf percussion = new PercussionShelf("Side Shelf");
        percussion.SetInstrumentName("Snare Drum");
        percussion.SetIsOn(true);
        console.AddComponent(percussion);
        
        DancingCat cat = new DancingCat("Feline Fun");
        cat.SetOutfit("Sequined Vest");
        cat.SetIsOn(true); 
        console.AddComponent(cat);

        console.PlayShow();
    }
}
