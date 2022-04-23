using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    [SerializeField] GameManager dataManager;
    [SerializeField] int coinAmmount;
    [SerializeField] int scoreAmmount;
    [SerializeField] int scoreop;
    [SerializeField] int coinop;


    private void Awake() {
        coinop  = PlayerPrefs.GetInt("Coin", 0);
        scoreop = PlayerPrefs.GetInt("HighScore", 0);
    }
    public void SaveData()
    {
        CheckDatas();

        PlayerPrefs.SetInt("Coin", coinAmmount);
        if(PlayerPrefs.GetInt("HighScore",0) < scoreAmmount)
            PlayerPrefs.SetInt("HighScore", scoreAmmount);
        
    }

    public void CheckDatas()
    {
        coinAmmount =  PlayerPrefs.GetInt("Coin", 0) + dataManager.coin;
        scoreAmmount = dataManager.mainScore;
            
    }
}
