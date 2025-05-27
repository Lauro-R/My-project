using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerManager : MonoBehaviour
{
    [SerializeField]
    AudioMixer myMix;//acessa o Mixer selecionado com o script
    [SerializeField]
    AudioMixerSnapshot padrao;//Snapshots que permitem escolher padroes do mixer
    [SerializeField]
    AudioMixerSnapshot Battle;//Snapshots que permitem escolher padroes do mixer
    [SerializeField]
    AudioMixerSnapshot Overworld;//Snapshots que permitem escolher padroes do mixer

    //padrao.TransitionTo(0); Teste de explicação do ivan sobre como transicionar o audio entre batalha overworld e a musica padrão
    //Battle.TransitionTo(2); colocar isso em triggers é util para modificar o mixing do som em cada cena do jogo.
    //Overworld.TransitionTo(4);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float volumeAtual;
            myMix.GetFloat("MasterVolume", out volumeAtual);//salva na variavel Float o valor exposto no mixer
            volumeAtual = volumeAtual + 1f;//soma 1 ao valor para modificar o valor float
            myMix.SetFloat("MasterVolume", volumeAtual);//define o valor novo na variavel.
        }
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                float volumeAtual;
                myMix.GetFloat("MasterVolume", out volumeAtual);//salva na variavel Float o valor exposto no mixer
                volumeAtual = volumeAtual - 1f;//subtrai 1 ao valor para modificar o valor float
                myMix.SetFloat("MasterVolume", volumeAtual);//define o valor novo na variavel.
            }
        }
    }
    public void UpdateAudio(float newVolume)
    {
        Debug.Log(newVolume);

        float volume = 20f;
        if (newVolume >0)//gambiarra de float para fazer o audio escalar de uma forma melhor pro audio subir e descer de uma forma melhor
        {
            volume = volume * newVolume;
            volume -= 20f;//na saida do calculo remove-se o valor especificado do float acima para o volume poder zerar.
        }
        else
        {
            volume = -80;//necessario para zerar o audio
        }
        myMix.SetFloat("MusicVolume", volume);//coloca o volume acima no Mixer
    }
    public void UpdateAudioMaster(float newVolume) //versão lite usando logaritmo de base 10
    {
        myMix.SetFloat("MasterVolume", Mathf.Log10(newVolume) * 20f);
    }
    public void UpdateAudioSfx(float newVolume) //versão lite usando logaritmo de base 10
    {
        myMix.SetFloat("SFXVolume", Mathf.Log10(newVolume) * 20f);
    }
    /*
    public void UpdateAudioAdvanced(float newVolume) //gambiarra diferente para fazer o sistema de volume
    {
        float volume;
        volume = Mathf.Log10(newVolume * 20;
        Debug.Log(volume);
        myMix.SetFloat("MasterVolume", volume);//lembrar de colocar o valor minimo a 0.001
    }
    //ou
    public void UpdateAudioOneLine(float newVolume) //versão lite usando logaritmo de base 10
    {
       myMix.SetFloat("MasterVolume", Mathf.Log10(newVolume) * 20);
    }
     */
}