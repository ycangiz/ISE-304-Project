using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using MoveClass;
using BoardClass;

namespace GamerClass
{
    public class Gamer : NetworkBehaviour
    {

        public bool startMoving = false;

        public GameObject attached;
        public int playerNum;
        public int location=0;
        public int money;
        public List<Property> properties;
        public bool turn = false;
        Button button = GameObject.FindGameObjectWithTag("endbutton").GetComponent<Button>();

        public GameObject buy;
        public GameObject pass;
        public Text t;

        void Start()
        {
            money = 20000;
            playerNum = 1;
            buy =GameObject.Find("BuyButton");
            pass = GameObject.Find("PassButton");
            buy.SetActive(false);
            pass.SetActive(false);
        }
        public Gamer(int num, GameObject g)
        {
            button.onClick.AddListener(CmdEndTurn);
            attached = g;
            playerNum = num;
        }

        public void moveBiatch()
        {
            Move movement = GetComponent<Move>();
            movement.mainMovement();
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

        public void buyClicker()
        {
            Debug.Log("plaeyerNum= " + playerNum);
            Board.squares[location].owner = playerNum;
            Debug.Log("New owner num: " + Board.squares[location].owner);
            GameObject.Find("QuestionText").GetComponent<Text>().text = "";
            if (Board.squares[location].owner == 0)
            {
                Debug.Log("Money Test");
                Debug.Log(location);
                Debug.Log(Board.squares[location].name);
                money = money - Board.squares[location].buyPrice;
            }
            else if (Board.squares[location].owner == -1)
            {
                money = money - Board.squares[location].rent;
            }
        }

        public void passClicker()
        {
            Debug.Log("Passed.");
            GameObject.Find("QuestionText").GetComponent<Text>().text = "";
            //buy.SetActive(false);
            //pass.SetActive(false);

        }

        public bool done()
        {
            return !turn;
        }
        void Update()
        {
            if (startMoving)
            {
                moveBiatch();
                //startMoving = false;
                if (Board.squares[location].owner == 0)
                {
                    
                    buy.SetActive(true);
                    pass.SetActive(true);    
                    
                    //appearButton();
                    //GameObject.Find("BuyButton").;
                    //GameObject.Find("PassButton").SetActive(true);
                    t = GameObject.Find("QuestionText").GetComponent<Text>();
                    //Debug.Log(t.text);               
                    t.text = "Would you like to buy " + Board.squares[location].name + " for " + Board.squares[location].buyPrice + "$?";
                    //Debug.Log("Would you like to buy "+ Board.squares[location].name+" for "+ Board.squares[location].buyPrice+"$?");
                }
                //Debug.Log(Board.squares[location].name+"  "+Board.squares[location].owner);
            }
        }
        
        
        
        
    }
}
