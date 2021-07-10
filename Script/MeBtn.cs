using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeBtn : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Me");
    }

    public void Goback()
    {
        SceneManager.LoadScene("Father");
    }
}

