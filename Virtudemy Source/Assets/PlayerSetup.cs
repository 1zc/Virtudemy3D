using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class PlayerSetup : NetworkBehaviour
{

    public GameObject PassGUI;

    [SerializeField]
    Behaviour[] componentsToDisable;
    
    Camera sceneCamera;
    public bool connected = false;

    void Start()
    {
        if(!isLocalPlayer)
        {
            connected = true;
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }

        else
        {
            sceneCamera = Camera.main;
            if(sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        
        }
    }

    void OnDisable ()
    {
        if(sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }
}
