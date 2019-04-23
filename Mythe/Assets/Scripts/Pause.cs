using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public GameObject PauseUI;

    public bool paused = false;

    void Start()
    {

        PauseUI.SetActive(false);

    }

    void Update()
    {
        PauseSwitch();
    }

    public void PauseSwitch()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        paused = !paused;

        switch (paused)
        { 
            case true:
            PauseUI.SetActive(true);
            Time.timeScale = 0;
            break;
            case false:
            PauseUI.SetActive(false);
            Time.timeScale = 1;
            break;
        }
    }

    
}

