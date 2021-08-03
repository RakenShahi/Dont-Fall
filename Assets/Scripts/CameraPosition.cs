using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    [SerializeField]
    Transform playerPosition;

    void Update()
    {
        transform.position = playerPosition.position;
    }
}
