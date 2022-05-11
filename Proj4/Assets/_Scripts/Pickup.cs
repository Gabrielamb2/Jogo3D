using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject obj;
    public string name;

    GameManager gm;
    void Start(){
        gm = GameManager.GetInstance();
        
    }

    private void OnTriggerEnter(Collider collision)
  {
      Debug.Log("ola" + collision.gameObject.tag);
      
      if (collision.CompareTag("Player")){
          Destroy(gameObject);

          if (name == "key") gm.has_key = true;
          else if (name == "gem") gm.has_diamond = true;

          Debug.Log($"has {name} - gem {gm.has_diamond} - key {gm.has_key}");
      }
  }


}

// https://www.youtube.com/watch?v=NebeDbWjIXA

