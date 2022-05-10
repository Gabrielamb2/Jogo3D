using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoomDoor : MonoBehaviour
{
     GameManager gm;
    private bool open = false;
    private Animator anim;
    void Start()
    {
        gm = GameManager.GetInstance();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (gm.puzzle2_solved && !(open)){
            Debug.Log("Door Opened");
            anim.SetTrigger("OpenDoor");
            open=true;
        }
    }
}
