using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAndroid : MonoBehaviour
{
    public GameObject controls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform != RuntimePlatform.Android)
        {
            this.gameObject.SetActive(false);
        }
    }
}
