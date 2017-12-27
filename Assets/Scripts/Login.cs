using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    public Button yourButton;
    // Use this for initialization
    void Start () {
        //GameObject hudcanvas = GameObject.FindGameObjectWithTag("HUDCanvas");
        //GameObject logincanvas = GameObject.FindGameObjectWithTag("LoginCanvas");
        GameObject.Find("HUDCanvas").GetComponent<Canvas>().enabled = false;
    }


    //yourButton.onClick.AddListener(TaskOnClick);

 
    //GameObject login = GameObject.FindGameObjectWithTag("LoginButton");

    // Update is called once per frame 
    void Update () {
        //GameObject hudcanvas = GameObject.FindGameObjectWithTag("HUDCanvas");
        //GameObject logincanvas = GameObject.FindGameObjectWithTag("LoginCanvas");
        //GameObject login = GameObject.FindGameObjectWithTag("LoginButton");
        //Destroy(transform.parent.gameObject);

    }

    public void TaskOnClick()
    {
        //Destroy(transform.parent.gameObject);
        GameObject.Find("HUDCanvas").GetComponent<Canvas>().enabled = true;
        Scene active = SceneManager.GetActiveScene();
        SceneManager.LoadSceneAsync("scene1");
        
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("scene1"));
        SceneManager.UnloadSceneAsync(active);
        
        
        //SceneManager.LoadScene("scene1");//LoadLevel("scene1");
    }

    //private void OnMouseDown()
    //{
    //    //GameObject login = GameObject.FindGameObjectWithTag("LoginButton");
    //    //Destroy(login);
    //    Destroy(transform.parent.gameObject);
    //}

}
