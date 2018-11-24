using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class ClassInterfaceGUI : MonoBehaviour
{
    public void ObjectivesButton()
    {
        Debug.LogWarning("CLICKED--> OBJECTIVES");
        //Application.LoadLevel("Objectives");
    }

    public void Exit()
    {
        Debug.LogWarning("CLICKED--> EXIT");
        Debug.Log("Returning to WorldEnvironment");
        Application.LoadLevel("prototype");
    }

    public void Activities()
    {
        Debug.LogWarning("CLICKED--> ACTIVITIES");
        //Application.LoadLevel("Activities");
    }

    public void Quiz()
    {
        Debug.LogWarning("CLICKED--> QUIZ");
        //Application.LoadLevel("Quiz");
    }

    public void Animations()
    {
        Debug.LogWarning("CLICKED--> ANIMATIONS");
        //Application.LoadLevel("Animations");
    }
}
