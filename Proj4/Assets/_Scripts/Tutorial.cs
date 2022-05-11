using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject display;
    public float time = (float)15f;
    void Start()
    {
        Destroy(gameObject, time);
    }

  
}
