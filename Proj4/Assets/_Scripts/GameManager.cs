using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager
{
   public enum GameState { MENU, GAME, PAUSE, ENDGAME };
   public GameState gameState { get; private set; }
   public float timeRemainig = 0;

   public bool pause_to_menu = false;
   private static GameManager _instance;

   public bool waspaused = false;

   public bool puzzle1_solved = false;
   public bool puzzle2_solved = false;
   public bool victory = false;
   public bool has_diamond = false;
   public bool has_key = false;



   public static GameManager GetInstance()
   {
       if(_instance == null)
       {
           _instance = new GameManager();
       }

       return _instance;
   }

   public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    public void ChangeState(GameState nextState)
    {
    if (nextState == GameState.GAME && (gameState != GameState.PAUSE )) Reset();

    else if (nextState == GameState.GAME && (gameState == GameState.PAUSE )) 
        waspaused = true;

    else if (nextState == GameState.MENU && (gameState == GameState.PAUSE ))
        pause_to_menu = true;

    gameState = nextState;
    changeStateDelegate();
    }

    private void Reset()
    {
        timeRemainig = 420;
        puzzle1_solved = false;
        puzzle2_solved = false;
        victory = false;
        has_diamond = false;
        has_key = false;
    }
   private GameManager()
   {
       gameState = GameState.MENU;
       timeRemainig = 420;
       victory = false;
   }
}