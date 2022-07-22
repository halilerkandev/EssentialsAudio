using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAudio : MonoBehaviour
{
    private AudioSource audioSource;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Play();
    }

    void Play()
    {
        if (time == 0f)
        {
            audioSource.Play();
        }
        time = time + Time.deltaTime;
        if (time > 10f)
        {
            time = 0f;
        }
    }
}
