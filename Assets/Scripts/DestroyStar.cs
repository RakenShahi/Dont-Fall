using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStar : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("star")){
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        
    }
}
