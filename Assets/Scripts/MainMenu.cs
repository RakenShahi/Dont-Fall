using System.Diagnostics;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        //FindObjectOfType<generateCoin>().resetCoinCount();
       
        SceneManager.LoadScene("Game");
    }

    public void Instruction()
    {
        SceneManager.LoadScene("Instruction");
    }

    public void HomeScreen()
    {
        SceneManager.LoadScene("Menu");
    }

    public void level2()
    {
      

        SceneManager.LoadScene("Platform2");
    }

    public void QuitOrCloseGame() {
        
        Application.Quit();
    }
}
