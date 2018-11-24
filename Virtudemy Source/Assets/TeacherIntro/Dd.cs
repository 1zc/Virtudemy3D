using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Text.RegularExpressions;

public class Dd : MonoBehaviour {

	[SerializeField]
	
	public GameObject classroom;
	public GameObject subject;

	public GameObject C1;
	public GameObject Math;

	public GameObject Pass;
    public GameObject CLASSROOMMENUBUTTON;
    public GameObject SUBMENUBUTTON;

	public string Cla;
	public string Sub;
	public int C;
	public string M;
	public string P;
    public string password;

	public bool Pw;

    private void Start()
    {
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = false;
        SUBMENUBUTTON.GetComponent<EmptyFile>().enabled = false;

    }

    public void Class1()
	{
        C = 1;
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void Class2()
    {
        C = 2;
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void Class3()
    {
        C = 3;
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void Class4()
    {
        C = 4;
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void Class5()
    {
        C = 5;
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void Class6()
    {
        C = 6;
        CLASSROOMMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void SubMath ()
	{
        M = "Mathematics";
        SUBMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void SubSci ()
    {
        SUBMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void SubEng ()
    {
        SUBMENUBUTTON.GetComponent<EmptyFile>().enabled = true;
    }

    public void EnterButtonYA()
    {
        Application.LoadLevel("TMenu");
    }

    public void MAINLOG()
    {
        Application.LoadLevel("Menu");
    }

    public void Ent()
	{
        password = Pass.GetComponent<InputField>().text;
		if (password != "")
        {

			Pw = true;
            System.IO.File.WriteAllText(@"Assets\Data Storage\" + password + ".txt", password);
            Debug.LogWarning("Stored pass.");
            Application.LoadLevel ("TMenu"); 
		}
        else
        {
			Debug.LogWarning ("No Password Entered ");
		}
	}
}
