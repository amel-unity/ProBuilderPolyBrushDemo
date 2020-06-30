using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeSoundManager : MonoBehaviour
{
    public AudioSource shakeSong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            shakeSong.Play();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            shakeSong.Pause();
        }
    }
}
