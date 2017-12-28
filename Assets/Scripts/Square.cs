using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {
    public string type;
    public string name;
    public int buyPrice;
    public int owner;
    public int housePrice;
    public int hotelPrice;
    public int mortgagePrice;
    public int rent;

    public Square(string nm,int bPr,int hsPr,int htPr,int mPr,int rt)
    {
        type = "Property";
        name = nm;
        buyPrice = bPr;
        housePrice = hsPr;
        hotelPrice = htPr;
        mortgagePrice = mPr;
        owner = 0;
        rent = rt;
    }
    public Square(string nm, int bPr,int mPr, int rt)
    {       
        type = "Station";
        name = nm;
        buyPrice = bPr;
        mortgagePrice = mPr;
        owner = 0;
        rent = rt;
    }
    public Square(string nm,int rt)
    {
        type = "Tax";
        owner = -1;
        name = nm;
        rent = rt;
    }
    public Square(string nm)
    {
        name = nm;
        type = "OTHER";
        if (name == "CHANCE")
        {
            owner = -2;
        }
        else if (name == "COMMUNITY CHEST")
        {
            owner = -3;
        }
        else if (name == "START")
        {
            owner = -4;
        }
        else if (name == "GO TO JAIL")
        {
            owner = -5;
        }
        else
        {
            owner = -6;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
