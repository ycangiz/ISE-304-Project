using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using DiceClass;
using RollClass1;
using GamerClass;

namespace MoveClass
{
    public class Move : NetworkBehaviour
    {
        public float speed = 2f;

        float cameraDistance = 8f;
        float cameraHeight = 8f;

        Vector3 cameraOffset;
        Transform mainCamera;

        public int counter;
        bool updater = true;
        
        Dice d1;
        Dice d2;
        
     

        private float timer = 0;

        private float timerMax = 0;

        void Start()
        {
            if (!isLocalPlayer)
            {
                Destroy(this);
                return;
            }
            counter = gameObject.GetComponent<Gamer>().location;

            cameraOffset = new Vector3(0f, cameraHeight, cameraDistance);
            mainCamera = Camera.main.transform;
            MoveCamera();
        }
        
        public void checkDice()
        {
            /*
            d1 = GameObject.FindGameObjectWithTag("Dice1(clone)").GetComponent<Dice>();
            d2 = GameObject.FindGameObjectWithTag("Dice2(clone)").GetComponent<Dice>();
            */
            
            GameObject dice1 = GameObject.Find("Dice1(Clone)");
            GameObject dice2 = GameObject.Find("Dice2(Clone)");
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

        public void mainMovement()
        {
            checkDice();
            if (!d1.isMoving && !d2.isMoving)
            {
                gameObject.GetComponent<Gamer>().startMoving = false;
                int num = d1.showDice() + d2.showDice();
            //int num = totalNum;
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
                    MoveCamera();
                }
                gameObject.GetComponent<Gamer>().location= counter;
                //updater = false;
            }
        }
        void Update()
        {
            //mainMovement();
        }
        void MoveCamera()
        {
            mainCamera.position = transform.position;
            mainCamera.rotation = transform.rotation;
            mainCamera.Translate(cameraOffset);
            mainCamera.LookAt(transform);
        }
    }
}