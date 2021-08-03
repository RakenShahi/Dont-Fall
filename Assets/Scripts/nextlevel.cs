using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public void nxtlevel(){
        SceneManager.LoadScene("level2");

    }
    public void mainmenu(){
        SceneManager.LoadScene("menu");
    }
}
