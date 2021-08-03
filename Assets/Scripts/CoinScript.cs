using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class CoinScript : MonoBehaviour
{
   public AudioClip coinSound;
   public GameObject cube;
   int score=Scoremanager.coinscore;
   public string TextureURL = "";
 
   void Start()
    {
       
    }
 
    void OnTriggerEnter(Collider other)
 {
   
     if (other.gameObject.CompareTag("Player"))
     {
        Destroy(gameObject);
          FindObjectOfType<Scoremanager>().AddScore();
          
          AudioSource.PlayClipAtPoint(coinSound,transform.position);
         
          Destroy(gameObject);
         
          
          } // if you want to destroy the key as well
     }
}
 
   



