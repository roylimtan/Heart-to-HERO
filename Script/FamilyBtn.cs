using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FamilyBtn : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Family");
    }

    public void Goback()
    {
        SceneManager.LoadScene("Sister");
    }
}
