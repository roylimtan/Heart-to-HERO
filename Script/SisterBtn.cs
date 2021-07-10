using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SisterBtn : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Sister");
    }

    public void Goback()
    {
        SceneManager.LoadScene("GameOver");
    }
}
