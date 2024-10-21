using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class Controller : MonoBehaviour
{
    public EventReference soundEvent;  
    FadeInOut fade;
    // Start is called before the first frame update
    void Start()
    {
        fade = FindAnyObjectByType<FadeInOut>();

        fade.FadeOut();

        SoundSwoosh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void SoundSwoosh()
    {
            EventInstance sound = RuntimeManager.CreateInstance(soundEvent);
            sound.start();
            sound.release(); 
    }
}
