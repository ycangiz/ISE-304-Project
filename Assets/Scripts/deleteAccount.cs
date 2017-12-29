using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.Collections;
using UnityEngine.UI;

public class deleteAccount : MonoBehaviour {
	private string Username;
	private string Password;
	public GameObject username;
	public GameObject password;
	public Text t;
	private string[] Lines;
	private string DecrptedPassword;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
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
                DeleteButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }

    public void DeleteButton()
	{
        bool UN = false;
        bool PW = false;
        if (Username != "")
		{
            if (System.IO.File.Exists(@"./" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"./" + Username + ".txt");
            }
            else {
                t.text = "User does not exist!";
            }
		}
		else
		{
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
		else
		{
			t.text = ("Password field empty!");
		}
        if (UN = true && PW == true)
        {
            System.IO.File.Delete(@"./" + Username + ".txt");
            t.text = ("Deleted Successfully!");
        }
        /*else {
            t.text = ("Couldn't delete the account!");
        }*/
        //t.text = UN + " " + PW;
	}

}
