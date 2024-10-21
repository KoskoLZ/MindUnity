using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class DestroyGlass : MonoBehaviour
{
    public EventReference soundEvent;  

    // Gitdas


    private void OnTriggerEnter(Collider col)
    {
       Destroy(this.gameObject);
       SoundGlassBreak();
    }

    public void SoundGlassBreak()
    {
            EventInstance sound = RuntimeManager.CreateInstance(soundEvent);
            sound.start();
            sound.release(); 
    }
}
