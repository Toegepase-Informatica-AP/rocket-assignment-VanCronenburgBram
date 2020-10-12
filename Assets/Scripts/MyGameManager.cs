using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject Rocket;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    private Health healthRocket;
    public int points;

    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates gameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        GameOverCanvas.SetActive(false);
        MainCanvas.SetActive(true);
        if (Rocket == null)
        {
            Rocket = GameObject.Find("Rocket");
        }
        healthRocket = Rocket.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthRocket.isAlive)
                {
                    gameState = GameStates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
