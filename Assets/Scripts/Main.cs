using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    List<Gamer> PlayerNames;
    int turnCounter;
    Gamer currentPlayer;
	// Use this for initialization
	void Start () {
        turnCounter = 0;

        PlayerNames.Add(new Gamer("Player1"));
        PlayerNames.Add(new Gamer("Player2"));
        PlayerNames.Add(new Gamer("Player3"));
        PlayerNames.Add(new Gamer("Player4"));

        currentPlayer = PlayerNames[turnCounter];
    }
	
	// Update is called once per frame
	void Update () {
        ChangeTurn();
	}

    void ChangeTurn()
    {
        if(currentPlayer.done())
        {
            currentPlayer = PlayerNames[++turnCounter];
        }
    }
}
