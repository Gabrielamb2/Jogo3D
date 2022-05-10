using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCombination : MonoBehaviour
{
    private int[] result, combinacao_correta;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        result = new int[]{0,0,0,0};
        combinacao_correta = new int[]{5,3,4,1};
        Lock.Rotated += CheckResults;
        
        
    }

    private void CheckResults(string wheelName, int number){
        if (wheelName == "WheelOne"){
            result[0]=number;
        }
        if (wheelName == "WheelTwo"){
            result[1]=number;
        }
        if (wheelName == "WheelThree"){
            result[2]=number;
        }
        if (wheelName == "WheelFour"){
            result[3]=number;
        }

        Debug.Log($"result, combinacao_correta");

        if (result[0]==combinacao_correta[0] && result[1]==combinacao_correta[1] && result[2]==combinacao_correta[2] && result[3]==combinacao_correta[3])
        {
        Debug.Log("Opened");
        anim.SetTrigger("Open");
        }
    }
}
