﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void BackToPrevious()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void BackToStart()
    {
        if (GameObject.Find("CatManager") != null)
        {
            Destroy(GameObject.Find("CatManager"));
        }
        if (GameObject.Find("SettingsManager") != null)
        {
            Destroy(GameObject.Find("SettingsManager"));
        }
        SceneManager.LoadScene(0);
    }
}