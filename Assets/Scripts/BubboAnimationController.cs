﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubboAnimationController : MonoBehaviour
{
    public Animator BubboAnimator;
    public SoundController SoundC;
    public GameObject Door0;

    void Fadein()
    {
        BubboAnimator.SetBool("Fadeout", false);
        BubboAnimator.SetBool("Fadein", true);
    }

    void Fadeout()
    {
        BubboAnimator.SetBool("Fadein", false);
        BubboAnimator.SetBool("Fadeout", true);
    }

    void PlayGetSound()
    {
        SoundC.PlayBubboGetSound();
    }

    void OpenDoor0()
    {
        Door0.SetActive(false);
    }

    //void SpawnParticle()
    //{
    //    Instantiate(Particle, transform.position, Quaternion.identity);
    //}
}
