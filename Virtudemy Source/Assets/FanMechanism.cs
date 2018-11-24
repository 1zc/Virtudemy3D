using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanMechanism : MonoBehaviour
{
    public float FanSpeed;

    void Update()
    {
        transform.Rotate(0, 0, FanSpeed*Time.deltaTime);
    }
}

