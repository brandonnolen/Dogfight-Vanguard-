using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {

public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

public void playagain()
    {
        SceneManager.LoadScene("Field");
    }
}
