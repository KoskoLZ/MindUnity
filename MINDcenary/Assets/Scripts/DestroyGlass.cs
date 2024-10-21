using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class DestroyGlass : MonoBehaviour
{
    public EventReference soundEvent;  

    // Gitdas

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }

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
