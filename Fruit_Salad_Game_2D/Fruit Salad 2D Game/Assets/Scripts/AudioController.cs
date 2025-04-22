using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController currentAudio;

    // Efects

    public AudioClip eat;
    public AudioClip jump;
    public AudioClip enemyHit;
    public AudioClip trampoline;
    public AudioClip win;
    public AudioClip finalWin;
    public AudioClip gameOver;

    // Musics
  
    public AudioClip music01;
    public AudioClip music02;
    public AudioClip music03;
    public AudioClip music04;
    public AudioClip music05;
    public AudioClip music06;
    public AudioClip music07;
    public AudioClip music08;
    public AudioClip music09;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        currentAudio = this;
        audioSource = GetComponent<AudioSource>();

    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void NoMusic()
    {
        audioSource.clip = null;
    }

}
