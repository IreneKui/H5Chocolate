using System;
using System.Collections.Generic;
public class Order
{
    public string message;
    // public Address adress;
    public bool confirmed;
    // public Package package;
    private List<Chocolate> items = new List<Chocolate>();
    // public Donation donation;

    public void AddChocolate(Chocolate chocolate)
    {
        items.Add(chocolate);
        Console.WriteLine("[Chocolate ordered]");
    }
    public string GetOrderList()
    {
        string output = "";
        foreach (Chocolate item in items)
        {
            output +=item.name + ", ";
        }
        return output;
    }
    public bool Confirm()
    {
        if(items.Count > 0)
        {
            confirmed = true;
        }
        return confirmed;
    }
    // bool Cancel();
}