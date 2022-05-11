
using UnityEngine;
using UnityEngine.UI;
public class UI_FimDeJogo : MonoBehaviour
{
   public Text message;
   public Text score;
   public Text highscore;
   public int recorde;

    GameManager gm;
    // public AudioClip perdeuSFX;


     public void Voltar()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }

    public void Sair() 
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        
        #endif
        Application.Quit();
    }


    private void OnEnable()
    {
        float minutes, seconds;
        string text;
        gm = GameManager.GetInstance();

        if(gm.victory && gm.timeRemainig >=0){
           message.text = "Você Ganhou!!";

           // highscore
        if ( (PlayerPrefs.GetInt("HighScore",(int)0)) >(int) gm.timeRemainig) 
            PlayerPrefs.SetInt("HighScore",(int) (int)gm.timeRemainig);

        recorde = PlayerPrefs.GetInt("HighScore",(int)0.0);

        minutes = Mathf.FloorToInt(gm.timeRemainig / 60);  
        seconds = Mathf.FloorToInt(gm.timeRemainig % 60);
        text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (recorde == gm.timeRemainig) score.text = "Novo melhor tempo!";
        else score.text = $"Recorde: {text}";
        highscore.text = $"Melhor tempo: {text}";

       } 
       else{
            // AudioManager.PlaySFX(perdeuSFX);
            message.text = "Você Perdeu!!";
            score.text = "";
            highscore.text ="";
       } 
    
    }

   
   
}