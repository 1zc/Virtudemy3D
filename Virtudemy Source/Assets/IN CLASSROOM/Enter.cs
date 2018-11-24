using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class Enter : MonoBehaviour {

	public GameObject I1;
	public GameObject I2;
	public GameObject I3;
	public GameObject I4;

	public GameObject O1;
	public GameObject O2;
	public GameObject O3;
	public GameObject O4;

	public GameObject Button;

	public string In1;
	public string In2;
	public string In3;
	public string In4;

    public string[] in1;
    public string[] in2;
    public string[] in3;
    public string[] in4;


    public void Obj()
	{
		Application.LoadLevel ("Srtudents");
	}

	public void Qui()
	{
		Application.LoadLevel ("Quiz");
	}

	public void Activ()
	{
		Application.LoadLevel ("ActivityStart");
	}

	public void Anim()
	{
		//Application.LoadLevel ("Class");
	}

	public void Exit69()
	{
		Application.LoadLevel ("Prototype");
	}

	public void Cancel()
	{
		Application.LoadLevel ("Class");
	}

	public void View()
	{
        O1.GetComponent<Text> ().text = System.IO.File.ReadAllText(@"Assets\Data Storage\In1.txt");
        O2.GetComponent<Text> ().text = System.IO.File.ReadAllText(@"Assets\Data Storage\In2.txt");
        O3.GetComponent<Text> ().text = System.IO.File.ReadAllText(@"Assets\Data Storage\In3.txt");
        O4.GetComponent<Text> ().text = System.IO.File.ReadAllText(@"Assets\Data Storage\In4.txt");

        Button.SetActive(false);

	}
	public void Exit(){
		
		Application.LoadLevel ("TMenu");

	}

	public void EnterButton(){
		
		Application.LoadLevel (@"IN CLASSROOM/StudObj");


        System.IO.File.WriteAllText(@"Assets\Data Storage\In1.txt",In1);
        System.IO.File.WriteAllText(@"Assets\Data Storage\In2.txt",In2);
        System.IO.File.WriteAllText(@"Assets\Data Storage\In3.txt",In3);
        System.IO.File.WriteAllText(@"Assets\Data Storage\In4.txt",In4);
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)){
			if (I1 .GetComponent<InputField>().isFocused){
				I2 .GetComponent<InputField>().Select();
			}
			if (I2 .GetComponent<InputField>().isFocused){
				I3 .GetComponent<InputField>().Select();
			}
			if (I3 .GetComponent<InputField>().isFocused){
				I4 .GetComponent<InputField>().Select();
			}

		}
		if (Input.GetKeyDown(KeyCode.Return)){
			if (In1 != ""|| In2 != ""|| In3 != ""|| In4 != "")
			{
				EnterButton();
			}
		}
		In1 = I1 .GetComponent<InputField>().text;
		In2 = I2 .GetComponent<InputField>().text;
		In3 = I3 .GetComponent<InputField>().text;
		In4 = I4 .GetComponent<InputField>().text;		
	}
}
