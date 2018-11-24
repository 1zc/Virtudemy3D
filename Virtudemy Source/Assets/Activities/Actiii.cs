using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Text.RegularExpressions;


public class Actiii : MonoBehaviour {

	public GameObject answer;

	public string Answer;
	public string a = "Kingfish";
	public string b = "kingfish";

	public string c = "Mullet";
	public string d = "mullet";

	public string e = "Snapper";
	public string f = "snapper";



	bool An = true;

	public void Check2()
	{
		

		if (Answer != "") {
			if (Answer == a || Answer == b) {
				An = true;
				Application.LoadLevel (@"EndActi");
			} 
				
		}
		else
			An = false;
			


	}

	public void Check1()
	{


		if (Answer != "") {
			if (Answer == c  || Answer == d) {
				An = true;
				Application.LoadLevel (@"EndActi");
			} 

		}
		else
			An = false;



	}

	public void Check3()
	{


		if (Answer != "") {
			if (Answer == e || Answer == f) {
				An = true;
				Application.LoadLevel (@"EndActi");
			} 

		}
		else
			An = false;



	}




	void OnGUI()
	{
		if (An == false){
			
		GUI.Label (new Rect (Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Answer Incorrect");
		}

	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		Answer = answer.GetComponent<InputField>().text;	

	}
}
