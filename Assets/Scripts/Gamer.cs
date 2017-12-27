using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer{

    private string name;
    public int money { get; private set; }
    public List<Property> properties;
    private bool turn = false;
    public Gamer(string username)
    {
        name = username;
        money = 20000;
    }

    public void startTurn()
    {
        turn = true;
    }

    public bool done()
    {
        return !turn;
    }

}
