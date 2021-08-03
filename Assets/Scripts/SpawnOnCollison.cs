using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnOnCollison   : MonoBehaviour
{

    [SerializeField]
    string sphereType;

    [SerializeField]
    bool spawnSelfBall = false;

    [SerializeField]
    bool spawnOtherBall = false;

    [SerializeField]
    GameObject spawnGo;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == sphereType)
        {
            if (spawnSelfBall)
                Instantiate(spawnGo, transform.position, Quaternion.identity);
            if (spawnOtherBall)
                Instantiate(spawnGo, collision.transform.position, Quaternion.identity);
        }
    }

}
