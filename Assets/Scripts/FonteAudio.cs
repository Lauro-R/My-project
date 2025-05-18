using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FonteAudio : MonoBehaviour
{
    [SerializeField]//permite acessar os valores na unity sem deixar publico
    AudioSource myAudioSource;
    [SerializeField]
    AudioSource audioBarulho;


    // Start is called before the first frame update
    void Start()
    {

        myAudioSource = GetComponent<AudioSource>();//adere�a um componente de audio ao nome na fun��o
        audioBarulho = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//faz com que o audio tocado pare pelo mesmo bot�o
        {
            if (audioBarulho.isPlaying)
            {
                audioBarulho.Pause();
            }
            else
            {
                myAudioSource.Play();
            }
        }
    }
}
