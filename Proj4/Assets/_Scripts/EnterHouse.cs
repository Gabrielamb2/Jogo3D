using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{

    private Animator anim;
    GameManager gm;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        gm = GameManager.GetInstance();
    }

    private void OnTriggerEnter(Collider collision)
  {      
      if (collision.CompareTag("Player")){
          if (gm.has_key)
            anim.SetTrigger("open");    
      }
  }
}
