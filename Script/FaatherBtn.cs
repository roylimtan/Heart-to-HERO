using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaatherBtn : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Father");
    }
}
