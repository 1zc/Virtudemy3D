using UnityEngine;
using System.Collections;

public class CleanQUIT : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {

            Application.Quit();
        }

    }
}
