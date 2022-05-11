using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{
    // Start is called before the first frame update

    private Text textComp;
    GameManager gm;
    void Start()
    {
        textComp = GetComponent<Text>();
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.timeRemainig <=0  && gm.gameState == GameManager.GameState.GAME) {
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }

        if (gm.gameState == GameManager.GameState.GAME){
            if (gm.timeRemainig > 0){
                gm.timeRemainig -= Time.deltaTime;
            } 

            float minutes = Mathf.FloorToInt(gm.timeRemainig / 60);  
            float seconds = Mathf.FloorToInt(gm.timeRemainig % 60);
            textComp.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }else{
            textComp.text = "";
        }

        
    }
}


// Fonte timer: https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/