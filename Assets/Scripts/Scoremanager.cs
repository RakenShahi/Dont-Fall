using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoremanager : MonoBehaviour
{
    [SerializeField] Text scoreText =null;
    public static int coinscore =0;
    int totalscore;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = coinscore.ToString();
    }
    public void AddScore(){
        
        coinscore++;
        if(coinscore==11){
            FindObjectOfType<Scoremanager>().reset();

            FindObjectOfType<generateCoin>().reset();

            SceneManager.LoadScene("youwon");
             
             
    }
       
        
       
        } 
        public void reset(){
            coinscore=0;
        }       
    }

