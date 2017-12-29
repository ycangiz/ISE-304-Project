using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class Login : MonoBehaviour {

    public Button yourButton;
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private string[] Lines;
    private string DecrptedPassword;
    public Text t;


    void Start()
    {
        GameObject.Find("HUDCanvas").GetComponent<Canvas>().enabled = false;
    }

    public void LoginButton() {
        bool UN = false;
        bool PW = false;
        if (Username != "")
        {
            if (System.IO.File.Exists(@"./" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"./" + Username + ".txt");
            }
            else
            {
                t.text = ("Username incorrect!");
            }
        }
        else {
            t.text = ("Username field empty!");
        }
        if (Password != "")
        {
            if (System.IO.File.Exists(@"./" + Username + ".txt"))
            {
                int i = 1;
                foreach (char c in Lines[2])
                {
                    i++;
                    char Decrypted = (char)(c / i);
                    DecrptedPassword += Decrypted.ToString();
                }
                if (Password == DecrptedPassword)
                {
                    PW = true;
                }
                else
                {
                    t.text = ("Password is invalid!");
                }
            }
            else
            {
                t.text = ("User does not exist!");
            }
        }
        else {
            t.text = ("Password field empty!");
        }
        if (UN == true && PW == true) {
            username.GetComponent<InputField>().text="";
            password.GetComponent<InputField>().text="";
            t.text = ("Login Successful!");
            GameObject.Find("HUDCanvas").GetComponent<Canvas>().enabled = true;
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync("scene1");

            SceneManager.SetActiveScene(SceneManager.GetSceneByName("scene1"));
            SceneManager.UnloadSceneAsync(active);
        }
    }

    
    void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Username != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }

    /*
    public void TaskOnClick()
    {
        GameObject.Find("HUDCanvas").GetComponent<Canvas>().enabled = true;
        Scene active = SceneManager.GetActiveScene();
        SceneManager.LoadSceneAsync("scene1");
        
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("scene1"));
        SceneManager.UnloadSceneAsync(active);      
    }*/

}
