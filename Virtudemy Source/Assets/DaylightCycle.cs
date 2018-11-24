using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightCycle : MonoBehaviour
{

    public float CycleSpeed;

    void Update()
    {
        transform.Rotate(Vector3.right * CycleSpeed);
    }
}
