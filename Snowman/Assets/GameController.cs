using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;

    public GameObject StartScreen;
    public GameObject PlayScreen;

    private WordGuesser.WordGame guessingGame;

    public void StartGame()
    {
        this.Message.text = "Can You Save The Snowman?";
        this.StartButton.gameObject.SetActive(true);
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        StartScreen.SetActive(false);
        PlayScreen.SetActive(true);
        
    }
    public void OpenStartScreen()
    {
        StartScreen.SetActive(true);
        PlayScreen.SetActive(false);
    }
    public void Start()
    {
        StartScreen.SetActive(true);
        PlayScreen.SetActive(false);
    }
}
