using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer{

    public int playerNum;
    public int money { get; private set; }
    public int location;
    public List<Property> properties;
    public bool turn = false;
    public Gamer(int num)
    {
        playerNum = num;
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
