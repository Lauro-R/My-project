using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FonteAudio : MonoBehaviour
{
    AudioSource myAudioSource;
    [SerializeField]
    AudioClip audioBarulho;


    // Start is called before the first frame update
    void Start()
    {

        myAudioSource = GetComponent<AudioSource>();//checa o componente dentro do objeto que contem esse script
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//faz com que o audio tocado pare pelo mesmo botão
        {
            if (myAudioSource.isPlaying)//um if para fazer o espaço ligar ou desligar o audio
            {
                myAudioSource.Pause();
            }
            else
            {
                myAudioSource.clip = audioBarulho;
                myAudioSource.Play();
            }
        }
    }
}
