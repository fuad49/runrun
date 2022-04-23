using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int coin;
    public int score;
    public int mainScore;
    public static GameManager inst;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI scoreText;

    public void IncreamentCoin()
    {
        coin++;

        coinText.text = "Coin : " + coin;
    }

    public void IncreamentScore()
    {
        score++;

        mainScore = score/2;

        scoreText.text = "Score : " + mainScore; 
    }

    private void Awake() 
    {
        inst = this;
    }
}
