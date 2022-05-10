﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    private bool isOpened;
    private Animator[] anim;
    private void Start()
    {
        result = new int[]{0,0,0,0};
        correctCombination = new int[] {5,3,4,1};
        isOpened = false;
        Rotate.Rotated += CheckResults;
        anim = GetComponentsInChildren<Animator>();
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "WheelOne":
                result[0] = number;
                break;

            case "WheelTwo":
                result[1] = number;
                break;

            case "WheelThree":
                result[2] = number;
                break;

            case "WheelFour":
                result[3] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1]
            && result[2] == correctCombination[2] && result[3] == correctCombination[3] && !isOpened)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
            isOpened = true;
            foreach (Animator anim in anim )  anim.SetTrigger("Open");
            Debug.Log("Abriuuuu");
        }
    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }
}
