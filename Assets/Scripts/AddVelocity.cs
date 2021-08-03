using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 forceVector;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += forceVector;
    }
}
