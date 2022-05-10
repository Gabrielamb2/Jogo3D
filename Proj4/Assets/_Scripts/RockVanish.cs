using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockVanish : MonoBehaviour
{
    GameManager gm;
    public GameObject rock;

    private bool destroyed = false;
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    void Update()
    {
        if (gm.puzzle1_solved && !(destroyed)){
            Debug.Log("Destroyed");
            Destroy(gameObject);
            destroyed=true;
        }
    }
}
