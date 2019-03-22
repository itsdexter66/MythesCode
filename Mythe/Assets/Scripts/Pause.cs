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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglepause();

        }

        if (paused)
        {

            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {

            PauseUI.SetActive(false);
            Time.timeScale = 1;

        }

    }

    public void togglepause()
    {
        paused = !paused;

    }
}

