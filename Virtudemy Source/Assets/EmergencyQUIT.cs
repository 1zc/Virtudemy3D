using UnityEngine;
using System.Collections;

public class EmergencyQUIT : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}