using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField userInput;
    public Text gameLable;
    public Button gameButton;
    public int randNum, minValue, maxValue;
    private bool isGameWon;
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    private void ResetGame()
    {
        if (isGameWon)
        {
            gameLable.text = "You Won! Guess a number between " + minValue + " & " + (maxValue - 1);
            isGameWon = false;
        }
        else
        {
            gameLable.text = "Guess a number between " + minValue + " & " + (maxValue - 1);
        }
        userInput.text = "";
        randNum = GetRandomNum(minValue, maxValue);
    }

    public void OnButtonClick()
    {
        string userInputValue = userInput.text;

        if (userInputValue !="")
        {
            int answer = int.Parse(userInputValue);

            if (answer == randNum)
            {
                gameLable.text = "Correct!, You Won!!";
                //gameButton.interactable = false;
                ResetGame();
            }
            else if(answer > randNum)
            {
                gameLable.text = "Tyr Lower!!";
            }
            else
            {
                gameLable.text = "Try higher!!";
            }
        }
        else
        {
            gameLable.text = "Enter a number!!";
        }

        
    }

    private int GetRandomNum(int min, int max)
    {
        int random = Random.Range(min, max);
        Debug.Log("min is " + min);
        Debug.Log("max is " + max);
    
        return random; 
    }
}

