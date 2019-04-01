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
 


    void Awake()
    {
            
    }

    
    void Update()
    {
        
    }

    public void resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void startscene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Optionscene()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void levelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void SelectScene()
    {
        SceneManager.LoadScene(scene);
    }

}
