using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Monopoly;
public class Move : MonoBehaviour
{
    public int counter = 0;
    bool updater = true;
    Dice d1;
    Dice d2;

    private float timer = 0;

    private float timerMax = 0;

    void Start()
    {
        GameObject dice1 = GameObject.Find("Dice1");
        GameObject dice2 = GameObject.Find("Dice2");
        d1 = dice1.GetComponent<Dice>();
        d2 = dice2.GetComponent<Dice>();
    }

    void moveRight4()
    {
        Vector3 position = this.transform.position;
        position.x = position.x + 4;
        this.transform.position = position;
    }
    void moveRight3()
    {
        Vector3 position = this.transform.position;
        position.x = position.x + 3;
        this.transform.position = position;
    }
    void moveDown4()
    {
        Vector3 position = this.transform.position;
        position.z = position.z - 4;
        this.transform.position = position;
    }
    void moveDown3()
    {
        Vector3 position = this.transform.position;
        position.z = position.z - 3;
        this.transform.position = position;
    }
    void moveLeft4()
    {
        Vector3 position = this.transform.position;
        position.x = position.x - 4;
        this.transform.position = position;
    }
    void moveLeft3()
    {
        Vector3 position = this.transform.position;
        position.x = position.x - 3;
        this.transform.position = position;
    }
    void moveUp4()
    {
        Vector3 position = this.transform.position;
        position.z = position.z + 4;
        this.transform.position = position;
    }
    void moveUp3()
    {
        Vector3 position = this.transform.position;
        position.z = position.z + 3;
        this.transform.position = position;
    }

    void mainMovement()
    {
        
        if (!d1.isMoving && !d2.isMoving)
        {
            int num = d1.showDice() + d2.showDice();
            while (num > 0)
            {               
                    if (counter == 0 || counter == 9)
                    {
                        moveRight4();
                        if (counter == 9)
                        {
                            this.transform.Rotate(0, 90, 0);
                        }
                    }
                    else if (counter < 9)
                    {
                        moveRight3();
                    }
                    else if (counter == 10 || counter == 19)
                    {
                        moveDown4();
                        if (counter == 19)
                        {
                            this.transform.Rotate(0, 90, 0);
                        }
                    }
                    else if (counter < 19)
                    {
                        moveDown3();
                    }
                    else if (counter == 20 || counter == 29)
                    {
                        moveLeft4();
                        if (counter == 29)
                        {
                            this.transform.Rotate(0, 90, 0);
                        }
                    }
                    else if (counter < 29)
                    {
                        moveLeft3();
                    }
                    else if (counter == 30 || counter == 39)
                    {
                        moveUp4();
                        if (counter == 39)
                        {
                            this.transform.Rotate(0, 90, 0);
                        }
                    }
                    else if (counter < 39)
                    {
                        moveUp3();
                    }
                    counter++;
                    num--;
                    if (counter == 40)
                    {
                        counter = 0;
                    }
            }
            //updater = false;
        }
    }
    void Update()
    {
        mainMovement();
    }
}