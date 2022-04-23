using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI score;
    [SerializeField]private TextMeshProUGUI coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            coin.text = "Coin : " + PlayerPrefs.GetInt("Coin", 0).ToString();
            score.text = "Score : " + PlayerPrefs.GetInt("HighScore", 0).ToString();

        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            PlayerPrefs.SetInt("Coin",PlayerPrefs.GetInt("Coin", 0) - 3) ;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("Coin",PlayerPrefs.GetInt("Coin", 0) + 3) ;
        }
    }
}
