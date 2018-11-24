using UnityEngine;
using System.Collections;

public class DoorMechanism : MonoBehaviour
{

    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;
    public GameObject PassGUI;
    public GameObject Move;
    public GameObject door;
    public bool Enabled = false;

    private bool passGUI;
    private bool open;
    public bool enter;
    private bool DoorClose = true;
    private bool DoorOpen = false;
    private bool PassUP = false;
    private bool Boxup = false;

    private Vector3 defaultRot;
    private Vector3 openRot;

    void Start()
    {
        //DontDestroyOnLoad(door);
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
        PassGUI.SetActive(false);
        Cursor.visible = false;
    }


    void Update()
    {

        if(door.GetComponent<EmptyFile>().enabled)
        {
            Enabled = true;
        }

        if (!door.GetComponent<EmptyFile>().enabled)
        {
            Enabled = false;
        }

        if (Enabled)
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

                PassGUI.SetActive(true);
                PassUP = true;
                Boxup = true;
                GameObject.Find("Player(Clone)").GetComponent<PlayerController>().enabled = false;
                GameObject.Find("Player(Clone)").GetComponent<PlayerMotor>().enabled = false;
                open = !open;

            }

            if (enter == false && DoorOpen == true)
            {
                CloseDoor();
            }

            if (PassUP)
            {
                //GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'F' to cancel");

                if (Input.GetKeyDown("f"))
                {
                    PassGUI.SetActive(false);
                    GameObject.Find("Player(Clone)").GetComponent<PlayerController>().enabled = true;
                    GameObject.Find("Player(Clone)").GetComponent<PlayerMotor>().enabled = true;
                    PassUP = false;
                    Boxup = false;
                    Cursor.visible = false;
                }
            }
        }

    }

    void OnGUI()
    {
        if (!Enabled)
        {
            if (enter)
            {
                GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "This room is locked.");
            }
        }

        if (Enabled)
        {
            if (enter)
            {
                if (!open)
                {
                    GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Use 'E' to enter classroom.");
                }

                if (Boxup)
                {
                    GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Use 'F' to cancel");
                    Cursor.visible = true;
                }

            }
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
            PassGUI.SetActive(false);
        }
    }

    void CloseDoor()
    {
        transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
        DoorClose = true;
        DoorOpen = false;
    }
}