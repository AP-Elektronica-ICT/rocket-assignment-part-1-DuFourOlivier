using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject GameOverCanvas;
    public GameObject VictoryCanvas;
    private Health healthPlayer;
    public enum GameStates 
    {
        Playing,
        GameOver,
        Victory
    }
    public GameStates gameState=GameStates.Playing;
    void Start()
    {
        GameOverCanvas.SetActive(false);
        if (player==null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    GameOverCanvas.SetActive(true);

                }
                else
                {

                    GameOverCanvas.SetActive(false);
                    if (finish.isFinsish)
                    {
                        VictoryCanvas.SetActive(true);
                        
                    }
                    else
                    {
                        VictoryCanvas.SetActive(false);
                    }
                }
                break;

        }
    }
}
