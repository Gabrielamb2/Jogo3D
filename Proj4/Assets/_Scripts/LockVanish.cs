using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockVanish : MonoBehaviour
{
    GameManager gm;
    public GameObject cadeado;
    private bool destroyed = false;
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    void Update()
    {
        // Debug.Log($"{gm.puzzle2_solved}");
        if (gm.puzzle2_solved && !(destroyed)){
            Debug.Log("Destroyed");
            Destroy(gameObject);
            destroyed=true;
        }
    }

}
