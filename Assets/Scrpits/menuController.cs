﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuController : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene(1);

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }
}
