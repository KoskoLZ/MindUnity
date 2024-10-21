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
        Debug.log("git");
    }

    private void OnTriggerEnter(Collider col)
    {
        // github-marcelo1
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
