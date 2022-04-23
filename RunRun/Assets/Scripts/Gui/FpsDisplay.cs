using UnityEngine;
using System.Collections;
using TMPro;

public class FpsDisplay : MonoBehaviour
{
    private int framerateCounter = 0;
    private float timeCounter = 0.0f;
    private float refreshTime = 1f;

    private float minimumFramerate = 0f;
    private float maximumFramerate = 696969f;
    [SerializeField] private TextMeshProUGUI fpsText;
    [SerializeField] private TextMeshProUGUI minFpsText;
    [SerializeField] private TextMeshProUGUI maxFpsText;



    private void Start() 
    {
        StartCoroutine(ResetMinFramerate());
    }


    private IEnumerator ResetMinFramerate()
    {
        yield return new WaitForSeconds(2f);
        minimumFramerate = 1000f;
        maximumFramerate = 0f;
    }


    private void Update() 
    {
        if(timeCounter < refreshTime)
        {
            timeCounter += Time.deltaTime;
            framerateCounter++;
        }
        else
        {
            float lastFramerate = framerateCounter/ timeCounter;
            if(minimumFramerate > lastFramerate)
            {
                minimumFramerate = lastFramerate;
            }
            if(maximumFramerate < lastFramerate)
            {
                maximumFramerate = lastFramerate;
            }
            framerateCounter = 0;
            timeCounter = 0f;
            fpsText.text = "FPS : " + lastFramerate.ToString("n2");
            maxFpsText.text = "MAX : " + maximumFramerate.ToString("n2");
            minFpsText.text = "MIN : " + minimumFramerate.ToString("n2");
        }
    }


}
