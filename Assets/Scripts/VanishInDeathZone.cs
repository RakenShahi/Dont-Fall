using System.Net;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.Tracing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VanishInDeathZone : MonoBehaviour
{

    public Text score;
    public Text highScore;
    public static int scoreKeeper;
    public int highScoreCounter = 0, scoreCounter = 0;

    [SerializeField]
    string sphereType;

    [SerializeField]
    bool destroySelfBall = false;

    [SerializeField]
    bool destroyOtherBall = false;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        PlayerPrefs.SetInt("score", scoreCounter);
        score.text = scoreCounter.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == sphereType)
        {
            if (destroySelfBall)
            {
                Destroy(this.gameObject);
            }

            if (destroyOtherBall)
            {
                Destroy(collision.gameObject);
                scoreCounter += 1;
                scoreKeeper = scoreCounter;
                PlayerPrefs.SetInt("score", scoreCounter);
                score.text = scoreCounter.ToString();

                highScoreCounter += 1;
               
                if (highScoreCounter > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore", highScoreCounter);
                    highScore.text = highScoreCounter.ToString();

                }
            }
        }
    }

}
