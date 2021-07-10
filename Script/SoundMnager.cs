using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
partial class Sound
{
    public string soundName;
    public AudioClip clip;
}

public class SoundMnager : MonoBehaviour
{
    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("브금 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    [Header("노래 등록")]
    [SerializeField] Sound bgmSon;

    [Header("현민 노래")]
    [SerializeField] AudioSource SonPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayRandomBGM();
    }


    public void PlayRandomBGM()
    {
        int random = Random.Range(0, 3);
        bgmPlayer.clip = bgmSounds[random].clip;
        bgmPlayer.Play();
        DontDestroyOnLoad(bgmPlayer);
    }

    public void PlaySon()
    {
        Destroy(bgmPlayer);

        SonPlayer.Play();
        DontDestroyOnLoad(SonPlayer);

    }
}
