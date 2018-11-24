using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorDoorwayMechanism : MonoBehaviour
{
    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;
    

    
    private bool open;
    private bool enter;
    private bool DoorClose = true;
    private bool DoorOpen = false;

    private Vector3 defaultRot;
    private Vector3 openRot;

    void Start()
    {
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
        
    }


    void Update()
    {
        if (open)
        {
            //Open door
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
            DoorClose = false;
            DoorOpen = true;
        }
        else
        {
            //Close door
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
            DoorClose = true;
            DoorOpen = false;
        }

        if (Input.GetKeyDown("e") && enter)
        {
            
            open = !open;
        }
    }

    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'E' to open the door");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
            
        }
    }
}

