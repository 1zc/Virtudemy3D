using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ClassPassGUI : MonoBehaviour {

    public GameObject password;
    public GameObject Player;
    public GameObject PassGUI;

    public bool IncorrectPass = false;
    public bool InvalidPass = false;

    private string Password;
    public string p = "DONOTTOUCHTHIS";

    public void EnterClassButton()
    {
        bool PW = false;

        if(Password != "")
        {
            if(System.IO.File.Exists (@"Assets\Data Storage\" + Password + ".txt") || Password == p)
            {
                PW = true;
            }

            else
            {
                Debug.LogWarning("Classroom Password Incorrect");
                IncorrectPass = true;
            }
        }

        else
        {
            Debug.LogWarning("Invalid Class Password entered.");
            InvalidPass = true;
        }

        if (PW == true)
        {
            password.GetComponent<InputField>().text = "";
            Debug.LogWarning("LOGIN SUCCESSFUL");
            Application.LoadLevel("Class");
        }
    }

    void Update()
    {
        Password = password.GetComponent<InputField>().text;

        //InvalidPass
        //IncorrectPass

        if (InvalidPass == true)
        {
            IncorrectPass = false;
        }

        if (IncorrectPass == true)
        {
            InvalidPass = false;
        }

        if (PassGUI.activeSelf == true)
        {
            Player.GetComponent<PlayerController>().enabled = false;
            Player.GetComponent<PlayerMotor>().enabled = false;
        }

        if (PassGUI.activeSelf == true)
        {
            Player.GetComponent<PlayerController>().enabled = true;
            Player.GetComponent<PlayerMotor>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (InvalidPass == false && IncorrectPass == false)
            {
                EnterClassButton();
            }
        }
    }

   void OnGUI()
    {
        if (InvalidPass == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Invalid Password.");
        }

        if (IncorrectPass == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Incorrect Password.");
            IncorrectPass = false;
            
        }
    }

    public void CloseButton()
    {
        if (PassGUI.activeSelf == true)
        {
            PassGUI.SetActive(false);
        }
    }
}
