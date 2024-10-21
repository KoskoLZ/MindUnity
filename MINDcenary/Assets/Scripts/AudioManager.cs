using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour
{

    [SerializeField] EventReference FootstepEvent;
    
FMOD.Studio.Bus Master;
float MasterVolume = 1f;

    void Awake()
    {
        Master = FMODUnity.RuntimeManager.GetBus("bus:/");
    }

    void Update()
    {
        Master.setVolume(MasterVolume);
    }

    public void MasterVolumeLevel(float newMasterVolume)
    {
        MasterVolume = newMasterVolume;
    }


    
}
