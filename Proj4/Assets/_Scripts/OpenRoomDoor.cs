using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoomDoor : MonoBehaviour
{
     GameManager gm;
    private bool open = false;
    private Animator anim;
    private AudioSource audio;
    void Start()
    {
        gm = GameManager.GetInstance();
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (gm.puzzle2_solved && !(open)){
            audio.Play();  
            Debug.Log("Door Opened");
            anim.SetTrigger("OpenDoor");
            open=true;
        }
    }
}
