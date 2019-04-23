using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject PauseUI;
    private Pause pause;
    public string scene;
 

    public void resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }



    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }



    public void SelectScene()
    {
        SceneManager.LoadScene(scene);
    }

}
