using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    Vector3 fallingPosition;

    [SerializeField]
    GameObject enemyTag;

    [SerializeField]
    float fallingInterval;

    float fallingTimer = 0;



    // Start is called before the first frame update
    void Start()
    {
        fallingTimer = fallingInterval;
    }

    // Update is called once per frame
    void Update()
    {
        fallingTimer -= Time.deltaTime;
        if (fallingTimer <= 0)
        {
            fallingTimer = fallingInterval;

            Vector3 v3SpawnPosition = transform.position;
            v3SpawnPosition += Vector3.right * fallingPosition.x * (Random.value - 0.5f);
            v3SpawnPosition += Vector3.up * fallingPosition.y * (Random.value - 0.5f);
            v3SpawnPosition += Vector3.forward * fallingPosition.z * (Random.value - 0.5f);

            Instantiate(enemyTag, v3SpawnPosition, Quaternion.identity);
        }
    }
}
