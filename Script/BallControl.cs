using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BallControl : MonoBehaviour
{

    float result_count;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Time.timeScale = 0;  //현재상태 정지

            GameControl.m_instance.OverGame();


            if (GameControl.m_instance.num_count > PlayerPrefs.GetFloat("Max", 0))
            {
                PlayerPrefs.SetFloat("Max", GameControl.m_instance.num_count);
                GameControl.m_instance.MaxResult.text = GameControl.m_instance.num_count.ToString();
            }
        }

        if (collision.gameObject.tag == "Ground")
        {
            GameControl.m_instance.num_count++;
            Destroy(gameObject);
        }
    }
}
