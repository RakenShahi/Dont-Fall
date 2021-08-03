using System.Diagnostics;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartmenu : MonoBehaviour
{
    public void StartGame()
    {
        

        SceneManager.LoadScene("Game");
    }
    public void Nextlvl()
    {
       
       
        SceneManager.LoadScene("Platform2");
    }
    public void Mainmenu()
    {
        

        SceneManager.LoadScene("Menu");
    }

}
