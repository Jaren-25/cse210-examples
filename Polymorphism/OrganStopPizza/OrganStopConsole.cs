using System;
using System.Collections.Generic;

public class OrganStopConsole
{
    private List<object> _components = new List<object>();

    public void AddComponent(object component)
    {
        _components.Add(component);
    }

    public void PlayShow()
    {
        Console.WriteLine("--- Starting the Wurlitzer Show ---");
        
        foreach (object item in _components)
        {
            if (item is PipeOrgan)
            {
                PipeOrgan pipe = (PipeOrgan)item;
                pipe.OpenValve();
            }
            else if (item is PercussionShelf)
            {
                PercussionShelf percussion = (PercussionShelf)item;
                percussion.Strike();
            }
            // 🛑 WE HAD TO MANUALLY ADD THIS BRANCH:
            else if (item is DancingCat)
            {
                DancingCat cat = (DancingCat)item;
                cat.BeginDance();
            }
        }
    }
}
