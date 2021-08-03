using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{

    //for joystick control
    protected Joystick joystick;
    
    //control using keyboard
    [SerializeField]
    Vector3 playerForce;
    [SerializeField]
    KeyCode positiveVal;
    [SerializeField]
    KeyCode negativeVal;


    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();


    }

    void FixedUpdate() {

        if (Input.GetKey(positiveVal))
            GetComponent<Rigidbody>().velocity += playerForce;


        if (Input.GetKey(negativeVal))
            GetComponent<Rigidbody>().velocity -= playerForce;
        
    }
    void Update()
    {

        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 5f, rigidbody.velocity.y, joystick.Vertical * 5f);

    }


    
}
