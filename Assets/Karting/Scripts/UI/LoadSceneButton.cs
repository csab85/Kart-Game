﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string SceneName;
        public bool firstKartSelected = false;

        public void LoadTargetScene() 
        {
            if (firstKartSelected)
            {
                SceneManager.LoadSceneAsync(SceneName);
            }

            else
            {
                firstKartSelected = true;
            }
        }
    }
}
