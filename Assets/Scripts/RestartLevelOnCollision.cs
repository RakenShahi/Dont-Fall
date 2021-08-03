using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    [SerializeField]
    string strTag2;

    public Text score;
    public int scoreCounter = 0;
   


    void Start()
    {

       // score.text = PlayerPrefs.GetInt("score", 0).ToString();
        //score.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            FindObjectOfType<Scoremanager>().reset();
        
            FindObjectOfType<generateCoin>().reset();
           
            SceneManager.LoadScene("GameOver");

            scoreCounter = 0;
            PlayerPrefs.SetInt("score", scoreCounter);
            score.text = scoreCounter.ToString();
        }
        if (collision.collider.tag == strTag2)
        {
            
            FindObjectOfType<lvlScoreManger>().reset();
           
            FindObjectOfType<lvlGenerateCode>().reset();
        
            SceneManager.LoadScene("GameOver");

            
            scoreCounter = 0;
            PlayerPrefs.SetInt("score", scoreCounter);
           
        }
    }

}
