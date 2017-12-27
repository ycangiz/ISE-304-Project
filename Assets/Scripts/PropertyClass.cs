using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property
{
    public string Name { get; private set; }
    public short Houses {
        get {
            return Houses;
        }
        private set {
            Houses = value;
        }
    }
    public bool Hotel {
        get
        {
            return Hotel;
        }
        private set
        {
            Hotel = value;
        }
    }
    public short HouseCost { get; private set; }
    public short HotelCost { get; private set; }

    public Property(string name, short houseCost, short hotelCost )
    {
        Name = name;
        Houses = 0;
        Hotel = false;
    }
    
    public void putHouseOnProperty()
    {
        Houses++;
    }

    public bool putHotelOnProperty()
    {
        if (Houses == 4)
        {
            Hotel = true;
            return true;
        }
        return false;
    }

}
