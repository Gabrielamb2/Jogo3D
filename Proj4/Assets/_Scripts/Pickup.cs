using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject obj;

    private void OnTriggerEnter(Collider collision)
  {
      Debug.Log("ola" + collision.gameObject.tag);
      
      if (collision.CompareTag("Player")){
          Debug.Log("oiee");
          Destroy(gameObject);
      }
  }


}

// https://www.youtube.com/watch?v=NebeDbWjIXA

