using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using MoveClass;
using GamerClass;
using RollClass1;
using RollClass2;
namespace DiceClass
{
    public class Dice : NetworkBehaviour
    {
        public Text t;
        float speed;
        Rigidbody rb;
        public bool isMoving;
        Transform faceup;
        float y = 0;

        void Start()
        {
            rb = gameObject.GetComponent<Rigidbody>();
            isMoving = true;
            Gamer movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Gamer>();
            movement.startMoving = true;
        }

        // Update is called once per frame
        void Update()
        {
            speed = rb.velocity.magnitude;

            if (speed == 0 && rb.position.y < 1)
            {
                //rb = GetComponent<Rigidbody>();
                isMoving = false;
            }
            if (!isMoving)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (transform.GetChild(i).position.y > y)
                    {
                        y = transform.GetChild(i).position.y;
                        faceup = transform.GetChild(i);
                    }
                }
            }
        }

        public int showDice()
        {
            
            string n = faceup.gameObject.name;
            if (gameObject.name=="Dice1(Clone)")
            {
                gameObject.GetComponent<Roll1>().textFields.GetComponent<Text>().text=faceup.gameObject.name;
            }
            else if (gameObject.name == "Dice2(Clone)")
            {
                gameObject.GetComponent<Roll2>().textFields.GetComponent<Text>().text = faceup.gameObject.name;
            }
            
            //Debug.Log(faceup.gameObject.name);
            Destroy(gameObject);
            return Convert.ToInt32(n);
        }
    }
}