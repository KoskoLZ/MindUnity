using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using FMODUnity;
using FMOD.Studio;

public class PlayerMovement : MonoBehaviour
{

    public EventReference soundEvent;  
    public float speed = 5;
    public float gravity = -9.81f;
    CharacterController cc;
    public float x;
    public float z;
    private Animator animator;
    public float speedrun;
    float shiftrun;

    public GameObject flashlight;


    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vertical", z);
        animator.SetFloat("horizontal", x);
        // float x = Input.GetAxis("Horizontal");
        // float z = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(KeyCode.E) && flashlight.activeSelf == false)
        {
            flashlight.SetActive(true);
            SoundFlash();
        }
        // if (flashlight.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        // {
        //     flashlight.SetActive(false);
        //     SoundFlash();
        // }




        if (Input.GetKeyDown(KeyCode.LeftShift) && z != 0)
        {
            speed = speed + speedrun;
            z += 1;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - speedrun;
            z -= 1;
        }





        Vector3 move = transform.right * x + transform.forward * z;
        
        cc.Move( move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        cc.Move(velocity * Time.deltaTime);
    }

    public void OnMoveEvent(InputAction.CallbackContext value)
    {
        x = value.ReadValue<Vector2>().x;
        z = value.ReadValue<Vector2>().y;
    }

    public void SoundFlash()
    {
            EventInstance sound = RuntimeManager.CreateInstance(soundEvent);
            sound.start();
            sound.release(); 
    }

}
