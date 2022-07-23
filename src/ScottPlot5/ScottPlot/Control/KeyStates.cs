﻿namespace ScottPlot.Control;

internal class KeyStates
{
    private readonly HashSet<Key> Pressed = new();

    public IReadOnlyCollection<Key> PressedKeys => Pressed.ToArray();

    public void Down(Key key)
    {
        if (key == Key.UNKNOWN)
            return;
        Pressed.Add(key);
    }

    public void Up(Key key)
    {
        if (key == Key.UNKNOWN)
            return;
        Pressed.Remove(key);
    }
}