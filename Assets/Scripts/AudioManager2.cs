using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager2 : MonoBehaviour
{

    public AudioClip[] clips;
    private AudioSource me;
    int index;

    private void Start()
    {
        me = GetComponent<AudioSource>();
    }
    public void Berrao()
    {

        me.clip = clips[index % clips.Length];

        me.Play();

    }

}