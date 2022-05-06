using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{

    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("open");
    }

    void Update()
    {
        
    }
}
