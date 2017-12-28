using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Gamer : NetworkBehaviour{


    public GameObject attached;
    public int playerNum;
    public int location;
    public int money;
    public List<Property> properties;
    public bool turn = false;
    Button button = GameObject.FindGameObjectWithTag("endbutton").GetComponent<Button>();

    public Gamer(int num, GameObject g)
    {
        button.onClick.AddListener(CmdEndTurn);
        attached = g;
        playerNum = num;
        money = 20000;
    }

    [Command]
    public void CmdStartTurn()
    {
        turn = true;
    }

    [Command]
    public void CmdEndTurn()
    {
        turn = false;
        Debug.Log("Turn ended");
    }


    public bool done()
    {
        return !turn;
    }

}
