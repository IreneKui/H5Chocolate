using System;
using System.Collections.Generic;
public class Order
{
    public string message;
    // public Address adress;
    // public bool confirmed;
    // public Package package;
    private List<Chocolate> items = new List<Chocolate>();
    // public Donation donation;

    public void AddChocolate(Chocolate chocolate)
    {
        items.Add(chocolate);
        Console.Write("[Chocolate ordered]");
    }
    // bool Confirm();
    // bool Cancel();
}