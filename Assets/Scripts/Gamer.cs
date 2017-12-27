using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Gamer : NetworkBehaviour{

    public GameObject attached;
    private string pname;
    public int money;
    public List<Property> properties;
    private bool turn = false;
    Button button = GameObject.FindGameObjectWithTag("endbutton").GetComponent<Button>();

    public Gamer(string username, GameObject g)
    {
        button.onClick.AddListener(CmdEndTurn);
        attached = g;
        name = username;
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
