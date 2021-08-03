using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCoin : MonoBehaviour
{
    public GameObject coin;
    public int xpos;
    public int zpos;
    public static int coinCount;
    int score=Scoremanager.coinscore;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coinDrop());
    }
IEnumerator coinDrop(){
    while (coinCount < 10) 
    {
        xpos = Random.Range(-11,2);
        zpos =Random.Range(-15,4);
        Instantiate(coin, new Vector3(xpos,2,zpos),Quaternion.identity);
        yield return new WaitForSeconds(15f);
        coinCount++;

    }
    if(coinCount==10){
         xpos = 7;
        zpos =6;
        Instantiate(coin, new Vector3(xpos,7,zpos),Quaternion.identity);
        yield return new WaitForSeconds(10f);
    
    }
    
} 
 public void reset(){
            coinCount=0;
        }   
}
