﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TouchScreenBtn : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Howto");
    }
}
