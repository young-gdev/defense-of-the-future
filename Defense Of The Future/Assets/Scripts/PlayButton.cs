using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public ParticleSystem particlePlay;
    [SerializeField] private AudioSource ClickAudio;

    public void PlayButtton()
    {
        ClickAudio.Play();
        particlePlay.Play();

        
        
        SceneManager.LoadScene(1);
        ;
    }
   
}
