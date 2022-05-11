using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{

    private Animator anim;
    GameManager gm;
    private AudioSource audio;

    
    void Start()
    {
        anim = GetComponent<Animator>();
        gm = GameManager.GetInstance();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
  {      
      if (collision.CompareTag("Player")){
          if (gm.has_key)
            audio.Play();  
            anim.SetTrigger("open");  
      }
  }
}
