using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class lvlStarScript : MonoBehaviour
{
   public AudioClip coinSound;
   public GameObject cube;
   int score=Scoremanager.coinscore;
   public string TextureURL = "";
  // private void OnTriggerEnter(Collider other)
   //{
      //ScoreTextScript.coinAmount +=1;
    //  FindObjectOfType<Scoremanager>().AddScore();
       
      //    Destroy (gameObject);

   //}
   void Start()
    {
       
    }
 
    void OnTriggerEnter(Collider other)
 {
   
     if (other.gameObject.CompareTag("player2"))
     {
        Destroy(gameObject);
          FindObjectOfType<lvlScoreManger>().AddScore();
          
          AudioSource.PlayClipAtPoint(coinSound,transform.position);
         
          Destroy(gameObject);
        
          
          } // if you want to destroy the key as well
     }
}
 
   



