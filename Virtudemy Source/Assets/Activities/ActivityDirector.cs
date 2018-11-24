using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityDirector : MonoBehaviour
{
    public void Level1()
    {
        Application.LoadLevel("Acti1");
    }

    public void Level2()
    {
        Application.LoadLevel("Acti2");
    }

    public void Level3()
    {
        Application.LoadLevel("Acti3");
    }

    public void GoBackToCLASS()
    {
        Application.LoadLevel("Class");
    }

    public void TPanel()
    {
        Application.LoadLevel("TMenu");
    }
}
