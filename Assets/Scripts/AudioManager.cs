using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length)];
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void play()
    {
        AudioClip audioClip = RandomClip();
        audioSource.PlayOneShot(audioClip);
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            play();
        }
    }

    private void Awake()
    {
        GameObject[] music = GameObject.FindGameObjectsWithTag("Music");
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
