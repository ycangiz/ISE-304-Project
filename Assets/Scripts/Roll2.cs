using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
namespace RollClass2
{
    public class Roll2 : NetworkBehaviour
    {

        GameObject dice;
        public GameObject textFields;

        private void Start()
        {

            textFields = GameObject.Find("Dice2Val");
            textFields.GetComponent<Text>().text = "";
            dice = gameObject;
        }

        public void RollDice()
        {

            dice = Instantiate(gameObject);
            Rigidbody rb = dice.GetComponent<Rigidbody>();
            int r = Random.Range(0, 1);
            if (r == 0)
            {
                rb.AddTorque(Random.Range(0, 1000) % 10, Random.Range(0, 1000) % 10, Random.Range(0, 1000) % 10);
                rb.AddForce(Random.Range(0, 1000) % 10 * 20, Random.Range(0, 1000) % 10 * 20, Random.Range(0, 1000) % 10 * 20);
            }
            else
            {
                rb.AddForce(-Random.Range(0, 1000) % 10 * 20, -Random.Range(0, 1000) % 10 * 20, -Random.Range(0, 1000) % 10 * 20);
                rb.AddTorque(-Random.Range(0, 1000) % 10, -Random.Range(0, 1000) % 10, -Random.Range(0, 1000) % 10);
            }

        }
    }
}
