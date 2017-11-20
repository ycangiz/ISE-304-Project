/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDice : MonoBehaviour
{
    Camera c;
    GameObject[] Dices;
    Transform Player1;
    Transform Player2;
    Vector3 Offset = new Vector3(0,20,0);

    void Start()
    {
        c = GetComponent<Camera>();
        Dices = GameObject.FindGameObjectsWithTag("Dice");
        Player1 = Dices[0].transform;
        Player2 = Dices[1].transform;
    }
    void LateUpdate()
    {
        if (Player1!= null && Player2 != null)
        {

            Vector3 tmp = (Player1.position + Player2.position)/2 + Offset;




        }
        
        
    }
}*/