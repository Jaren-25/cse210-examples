using System;
using System.Collections.Generic;

public class OrganStopConsole
{
    private List<WurlitzerComponent> _components = new List<WurlitzerComponent>();

    public void AddComponent(WurlitzerComponent component)
    {
        _components.Add(component);
    }

    public void PlayShow()
    {
        Console.WriteLine("--- Starting the Improved Wurlitzer Show ---");
        Console.WriteLine("(Using Polymorphism - no manual type checking!)");

        foreach (WurlitzerComponent item in _components)
        {
            // This is the win! One line calls the correct method for ANY component.
            item.Perform();
        }
    }

    public virtual void DescribeInstrument()
    {
        foreach (WurlitzerComponent wurlitzerComponent in _components)
        wurlitzerComponent.ToString();
    }
}
