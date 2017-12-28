using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.Collections;

public class register : MonoBehaviour {
	public GameObject username;
	public GameObject password;
	public GameObject email;
	public GameObject confPassword;
    public Text t;
	private string Username;
	private string Password;
	private string form;
	private string Email;
	private string ConfPassword;
	private bool EmailValid = false;
	private string[] Characters = {"0","1","2","3","4","5","6","7","8","9","_","-","a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
	"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","p","Q","R","S","T","U","V","W","X","Y","Z"};


	// Use this for initialization
	void Start () {
	}

	public void RegisterButton() {
		//Debug.Log("Registration successful!");

		bool UN = false;
		bool EM = false;
		bool PW = false;
		bool CPW = false;

		if (Username != "") {
			if (!System.IO.File.Exists(@"./" + Username + ".txt")) {
				UN = true;
			}
			else
			{
				t.text = ("Username Taken!");             
			}
		}
		else {
            t.text = ("Username field empty!");
		}
		if (Email != "") {
			EmailValidation();
			if (EmailValid){
				if (Email.Contains("@")){
					if (Email.Contains(".")) {
						EM = true;
					}
					else{
                        t.text = ("Email is incorrect!");
					}
				}
				else{
                    t.text = ("Email is incorrect!");
				}
			}
			else {
                t.text = ("Email is incorrect!");
			}
		}
		else {
            t.text = ("Email field is empty!");
		}
		if (Password != "") {
			if (Password.Length > 5) {
				PW = true;
			}
			else{
                t.text = ("Password must be at least 6 characters long!");
			}
		}
		else {
            t.text = ("Password field is empty!");
		}
		if (ConfPassword != "") {
			if (ConfPassword == Password) {
				CPW = true;
			}
			else{
                t.text = ("Passwords do not match!");
			}
		}
		else {
            t.text = ("Confirm Password Field is empty!");
		}
		if(UN == true && PW == true && EM == true && CPW == true) {
			bool Clear = true;
			int i = 1;
			foreach (char c in Password) {
				if (Clear) {
					Password = "";
					Clear = false;
				}
				i++;
				char Encrypted = (char)(c * i);
				Password += Encrypted.ToString();
			}
			form = (Username + System.Environment.NewLine + Email + System.Environment.NewLine  + Password);
			System.IO.File.WriteAllText(@"./" + Username + ".txt",form);
			username.GetComponent<InputField>().text="";
			password.GetComponent<InputField>().text="";
			email.GetComponent<InputField>().text="";
			confPassword.GetComponent<InputField>().text="";
            t.text = ("Registration Complete!");
		}
	  
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)) {
			if (username.GetComponent<InputField>().isFocused) {
				email.GetComponent<InputField>().Select();
			}
			if (email.GetComponent<InputField>().isFocused)
			{
				password.GetComponent<InputField>().Select();
			}
			if (password.GetComponent<InputField>().isFocused)
			{
				confPassword.GetComponent<InputField>().Select();
			}
		}

		if (Input.GetKeyDown(KeyCode.Return)) {
			if (Password != "" && Email != "" && Username != "" && ConfPassword != "") {
				RegisterButton();
			}
		}

		Username = username.GetComponent<InputField>().text;
		Password = password.GetComponent<InputField>().text;
		Email = email.GetComponent<InputField>().text;
		ConfPassword = confPassword.GetComponent<InputField>().text;
	}

	void EmailValidation() {
		bool SW = false;
		bool EW = false;
		for (int i = 0; i < Characters.Length; i++)
		{
			if (Email.StartsWith(Characters[i]))
			{
				SW = true;
			}
		}
		for (int i = 0; i < Characters.Length; i++) {
			if (Email.EndsWith(Characters[i]))
			{
				EW = true;
			}
		}
		if (SW == true && EW == true)
		{
			EmailValid = true;
		}
		else {
			EmailValid = false;
		}
	}

}
