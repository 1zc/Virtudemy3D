using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{
    public bool DisplayLockedMessage = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DisplayLockedMessage = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DisplayLockedMessage = false;
        }
    }

    void OnGUI()
    {
        if (DisplayLockedMessage == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "This Door is Locked.");
        }
    }

}
