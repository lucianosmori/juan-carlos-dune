using System;
using System.Collections.Generic;

public class PlanetaryEvents
{
    private Dictionary<string, Action> eventDictionary = new Dictionary<string, Action>();

    public void SubscribeToEvent(string eventName, Action listener)
    {
        if (!eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName] = listener;
        }
        else
        {
            eventDictionary[eventName] += listener;
        }
    }

    public void UnsubscribeFromEvent(string eventName, Action listener)
    {
        if (eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName] -= listener;
        }
    }

    public void TriggerEvent(string eventName)
    {
        if (eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName]?.Invoke();
        }
    }
}