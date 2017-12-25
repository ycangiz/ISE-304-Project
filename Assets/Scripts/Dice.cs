using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

    public Text t;
    float speed;
    Rigidbody rb;
    bool isMoving;
    Transform faceup;
    float y = 0;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        isMoving = true;
	}

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;

        if (speed == 0)
        {
            isMoving = false;
        }
        if (!isMoving)
        {
            for (int i=0; i<6; i++)
            {
                if(transform.GetChild(i).position.y > y)
                {
                    y = transform.GetChild(i).position.y;
                    faceup = transform.GetChild(i);
                }
            }
            showDice();
            
        }

    }

    private void showDice()
    {
        t.text = faceup.gameObject.name;
    }
}
