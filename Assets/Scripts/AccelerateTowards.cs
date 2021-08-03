using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour
{
    Rigidbody rigid;

    [SerializeField]
    Transform dTowards;

    [SerializeField]
    float speedF;

 

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (dTowards == null)
        {
            dTowards = FindObjectOfType<PlayerControl>().transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3MeTowardsTarget = dTowards.position - transform.position;
        rigid.velocity += v3MeTowardsTarget.normalized * speedF * Time.deltaTime;
    }
}
