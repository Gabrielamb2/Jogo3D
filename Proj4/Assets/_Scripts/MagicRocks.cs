using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicRocks : MonoBehaviour
{

    GameManager gm;
    public AudioClip som_ganhou;
    public AudioClip som_perdeu;
    void Start(){
        gm = GameManager.GetInstance();
    }

    private void OnTriggerEnter(Collider collision)
  {
      Debug.Log("ola" + collision.gameObject.tag);
      
      if (collision.CompareTag("Player")){
          if(gm.timeRemainig > 0  && gm.gameState == GameManager.GameState.GAME) {
            if (gm.has_diamond){
              gm.victory=true;
            AudioManager.PlaySFX(som_ganhou);
            }else{
              AudioManager.PlaySFX(som_perdeu);
            }
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
      }
  }
}
