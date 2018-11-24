using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direct : MonoBehaviour {

	[SerializeField]

	public void Obj()
	{

	    Application.LoadLevel("Objectives");

	}

	public void Act()
	{

		Application.LoadLevel("TActStart");

	}

	public void Qui()
	{

		Application.LoadLevel("TQuiz");

	}


	public void Exi()
	{

		Application.LoadLevel("Tlog");

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
