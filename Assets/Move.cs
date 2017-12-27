using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Move : NetworkBehaviour
{

    public float speed = 2f;
    int counter = 0;

    float cameraDistance = 8f;
    float cameraHeight = 8f;

    Vector3 cameraOffset;
    Transform mainCamera;

    void Start()
    {
        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }

        cameraOffset = new Vector3(0f, cameraHeight, cameraDistance);
        mainCamera = Camera.main.transform;
        MoveCamera();
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

    void Update()
    {
        //Debug.Log(counter);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(counter);
            if (counter == 0 || counter == 9)
            {
                moveRight4();
            }
            else if (counter < 9)
            {
                moveRight3();
            }
            else if (counter == 10 || counter == 19)
            {
                moveDown4();
            }
            else if (counter < 19)
            {
                moveDown3();
            }
            else if (counter == 20 || counter == 29)
            {
                moveLeft4();
            }
            else if (counter < 29)
            {
                moveLeft3();
            }
            else if (counter == 30 || counter == 39)
            {
                moveUp4();
            }
            else if (counter < 39)
            {
                moveUp3();
            }
            counter++;
            if (counter == 40)
            {
                counter = 0;
            }
        }
        MoveCamera();
    }
    void MoveCamera()
    {
        mainCamera.position = transform.position;
        mainCamera.rotation = transform.rotation;
        mainCamera.Translate(cameraOffset);
        mainCamera.LookAt(transform);
    }
}