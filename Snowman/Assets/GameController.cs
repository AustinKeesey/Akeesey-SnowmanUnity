using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    private WordGame guessingGame;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    public GameObject OverScreen;
    public GameObject WonScreen;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text HiddenLetters;
    public UnityEngine.UI.Text LettersGuessed;
    public UnityEngine.UI.Text RemainingGuess;
    public UnityEngine.UI.Text CheckGuess;
    public void StartGame()
    {
        this.guessingGame = new WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
        this.Message.text = "Can you save the Snowman?";
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(true);
        this.OverScreen.gameObject.SetActive(false);
        this.WonScreen.gameObject.SetActive(false);
        this.CheckGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);

        this.HiddenLetters.text = this.guessingGame.GetWord();

        this.LettersGuessed.text = this.guessingGame.GetGuessedLetters();

        int remaining = guessingGame.GetGuessLimit() - guessingGame.GetIncorrectGuesses();

        this.RemainingGuess.text = $"You have {remaining} guesses remaining.";
        PlayerGuess.text = string.Empty;


        
    }

    public void Start()
    {
        this.StartScreen.gameObject.SetActive(true);

        this.PlayScreen.gameObject.SetActive(false);

        this.OverScreen.gameObject.SetActive(false);

        this.WonScreen.gameObject.SetActive(false);
    }
   
    public void SubmitGuess()
    {
        this.CheckGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);

        this.HiddenLetters.text = this.guessingGame.GetWord();

        this.LettersGuessed.text = this.guessingGame.GetGuessedLetters();

        int remaining = guessingGame.GetGuessLimit() - guessingGame.GetIncorrectGuesses();

        this.RemainingGuess.text = $"You have {remaining} guesses remaining.";
        PlayerGuess.text = string.Empty;
        if (this.guessingGame.IsGameOver())
        {
            this.PlayScreen.gameObject.SetActive(false);
            this.OverScreen.gameObject.SetActive(true);
        }
        if (this.guessingGame.IsGameWon())
        {
            this.PlayScreen.gameObject.SetActive(false);
            this.WonScreen.gameObject.SetActive(true);
        }

    }
}