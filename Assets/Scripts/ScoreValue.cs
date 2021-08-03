using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreValue : MonoBehaviour
{
    public Text scoreKeeperText;
    public int scoreKeeperValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        scoreKeeperValue = VanishInDeathZone.scoreKeeper;
        Debug.Log(scoreKeeperValue);
        PlayerPrefs.SetInt("scoreKeeperText", scoreKeeperValue);
        scoreKeeperText.text = scoreKeeperValue.ToString();
    }
}
