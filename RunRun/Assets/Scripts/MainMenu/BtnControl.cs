using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnControl : MonoBehaviour
{

    [SerializeField]private MainSpawner mainSpawner;

    public void OnPlayerSelect()
    {
        PlayerPrefs.SetInt("PlayerToSpawn",mainSpawner.arrayNo);
    }
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
