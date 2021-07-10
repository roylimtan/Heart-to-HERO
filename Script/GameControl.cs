using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject ball;
    [SerializeField] Transform create_ball;

    [SerializeField] Text t_count;

    public float num_count;

    [SerializeField] float speed;

    [SerializeField] GameObject G_Bonus;
    [SerializeField] Transform Create_Bonus_Ball;

    public Text MaxResult;

    public float Move;

    [SerializeField] GameObject GameOver;
    public bool isGmaeOver = false;
    public bool isRetryBtn = false;

    private static GameControl instance;

    public static GameControl m_instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameControl>();
            }

            return instance;
        }
    }

    void Awake()
    {
        // 싱글톤 변수 instance가 비어있는가?
        if (instance == null)
        {
            // instance가 비어있다면(null) 그곳에 자기 자신을 할당
            instance = this;
        }
        else
        {
            // instance에 이미 다른 GameManager 오브젝트가 할당되어 있는 경우

            // 씬에 두개 이상의 GameManager 오브젝트가 존재한다는 의미.
            // 싱글톤 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
        StartCoroutine(creat());
        StartCoroutine(Bonus());

        MaxResult.text = PlayerPrefs.GetFloat("Max", 0).ToString();

        isGmaeOver = false;
        isRetryBtn = false;
    }

    // Update is called once per frame
    void Update()
    {
 
         player.transform.Translate(new Vector3(Move * speed * Time.deltaTime, 0, 0)); //x로만 이동

         t_count.text = num_count.ToString();
        

    }

    IEnumerator creat()
    {
        for (int i = 0; i < 100; i++)
        {
            create_ball.position = new Vector3(Random.Range(-2.0f, 2.0f), 7, 0);

            Instantiate(ball, create_ball.position, create_ball.rotation);

            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator Bonus()
    {
        for (int i = 0; i < 100; i++)
        {
            Create_Bonus_Ball.position = new Vector3(Random.Range(-2.0f, 2.0f), 7, 0);

            Instantiate(G_Bonus, Create_Bonus_Ball.position, create_ball.rotation);

            yield return new WaitForSeconds(3.0f);
        }
    }

    public void OverGame()
    {
        GameOver.SetActive(true);
        isGmaeOver = true;
    }

    public void RetryBtn()
    {
        SceneManager.LoadScene("Ingame");
        Time.timeScale = 1f;
    }
}
