using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
namespace Monopoly
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
        }


        // Update is called once per frame
        void Update()
        {
            speed = rb.velocity.magnitude;

            if (speed == 0 && rb.position.y < 1)
            {
                rb = GetComponent<Rigidbody>();
                isMoving = true;
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
                showDice();

            }
        }

        public int showDice()
        {
            GameObject[] textFields = GameObject.FindGameObjectsWithTag("DiceValText");
            for (int i = 0; i < 2; i++)
            {
                if (textFields[i].GetComponent<Text>().text == "")
                {
                    textFields[i].GetComponent<Text>().text = faceup.gameObject.name;
                    i = 3;
                }
            }
            //Destroy(gameObject);
            Debug.Log(faceup.gameObject.name);
            return Convert.ToInt32(faceup.gameObject.name);
        }
    }
}