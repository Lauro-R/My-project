using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerManager : MonoBehaviour
{
    [SerializeField]
    AudioMixerManager myMix;
    [SerializeField]
    AudioMixerSnapshot padrao;//Snapshots que permitem escolher padroes do mixer
    [SerializeField]
    AudioMixerSnapshot Battle;
    [SerializeField]
    AudioMixerSnapshot Overworld;

    //padrao.TransitionTo(0);
    //Battle.TransitionTo(2);
    //Overworld.TransitionTo(4);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
