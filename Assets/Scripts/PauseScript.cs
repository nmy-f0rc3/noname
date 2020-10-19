using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public float timeRemaining = 10f;
    private Stopwatch stopwatch;
    public Text Timer;
    public float Seconds = 12f;
    public Canvas Pause;
    // Start is called before the first frame update
    void Start()
    {
        stopwatch = Stopwatch.StartNew();
    }

    void Update()
    {
        
        float secondsPassed = Mathf.Floor(stopwatch.ElapsedMilliseconds / 1000f);
        int secondsLeft = Mathf.FloorToInt(Seconds - secondsPassed);
        if (secondsLeft == 11)
        {
            Timer.text = "3";
            UnityEngine.Debug.Log("TEST - " + secondsLeft);

        }
        if (secondsLeft == 7)
        {
            UnityEngine.Debug.Log("TEST - " + secondsLeft);
            Timer.text = "2";
            

        }
        if (secondsLeft == 3)
        {
            UnityEngine.Debug.Log("TEST - " + secondsLeft);
            Timer.text = "1";
            
        }
        if (secondsLeft == 0)
        {
            UnityEngine.Debug.Log("TEST - " + secondsLeft);
            Timer.text = "0";
            stopwatch.Stop();
            Pause.gameObject.SetActive(false);
        }






    }


}

