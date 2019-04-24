using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public GameObject PauseUI;
    [SerializeField]
    private GameObject JumpButton;

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

        InActivateButtons();

    }

    public void togglepause()
    {
        paused = !paused;

    }

    public void InActivateButtons()
    {
        if (paused == true)
        {
            JumpButton.SetActive(false);
        }
        else
        {
            JumpButton.SetActive(true);
        }
    }
}

