using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class LevelUnlock : MonoBehaviour
    {

        private bool Level = true;
        public bool Level2 = false;
        public bool Level3 = false;

        public Button[] levels;
        // Use this for initialization
        void Start()
        {
        DontDestroyOnLoad(this.gameObject);

        for (int i = 0; i < levels.Length; i++)
            {
                //Changes the button's Normal color to the new color.
                levels[i].enabled = false;
            }
        }

        void FixedUpdate()
        {
           
            if (Level == true)
            {
                levels[0].enabled = true;

                ColorBlock colors = levels[0].colors;
                colors.normalColor = Color.grey;
                colors.highlightedColor = new Color32(220, 0, 220, 220);
                levels[0].colors = colors;


            }
          
            if (Level2 == true)
            {
                levels[1].enabled = true;

                ColorBlock colors = levels[1].colors;
                colors.normalColor = Color.grey;
                colors.highlightedColor = new Color32(220, 0, 220, 220);
                levels[1].colors = colors;
                

        }
         
            if (Level3 == true)
            {
                levels[2].enabled = true;

                ColorBlock colors = levels[2].colors;
                colors.normalColor = Color.green;
                colors.highlightedColor = new Color32(220, 0, 220, 220);
                levels[2].colors = colors;

            }
        }
    }