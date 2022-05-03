using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public ParticleSystem shopParticle;
    [SerializeField] private AudioSource clickAudio;

    public void ButtonShop()
    {
        shopParticle.Play();
        clickAudio.Play();
    }
}
