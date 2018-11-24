using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;

    // Use this for initialization
    void Start ()
    {
        DontDestroyOnLoad(one);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
