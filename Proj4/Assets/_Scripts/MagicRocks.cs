using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicRocks : MonoBehaviour
{

    GameManager gm;
    void Start(){
        gm = GameManager.GetInstance();
    }

    private void OnTriggerEnter(Collider collision)
  {
      Debug.Log("ola" + collision.gameObject.tag);
      
      if (collision.CompareTag("Player")){
          if(gm.timeRemainig > 0  && gm.gameState == GameManager.GameState.GAME) {
            if (gm.has_diamond) gm.victory=true;
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
      }
  }
}
