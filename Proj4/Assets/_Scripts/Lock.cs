using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lock : MonoBehaviour
{
    public static event Action<string, int> Rotated = delegate {};

    private bool coroutine;
    private int number;

    void Start()
    {
        coroutine=true;
        number=5;
    }

    private void OnMouseDown()
    {
        if (coroutine) StartCoroutine("RotateWheel");
    }

    private IEnumerator RotateWheel()
    {
        coroutine=false;

        for (int i=0; i<11; i++){
            transform.Rotate(0f, 0f, -3f);
            yield return new WaitForSeconds(0.01f);
        }
        coroutine = true;
        number++;
        if (number > 9) number=0;
        Rotated(name, number);
    }
}

// Referência:
// https://www.youtube.com/watch?v=SFwz9JBl9Bc
