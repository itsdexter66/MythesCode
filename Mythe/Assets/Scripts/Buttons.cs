using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

   

    void Start()
    {
    
    }

    
    void Update()
    {
        
    }

    void OnClick()
    {
     
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

}
