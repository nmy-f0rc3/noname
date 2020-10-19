using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScoreScript : MonoBehaviour
{
    public Text MyScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Points = GameObject.Find("Player");
        PlayerScripts Player = Points.GetComponent<PlayerScripts>();
        int MyPoints = Player.PlayerPoints;
        MyScore.text = "Score:" + MyPoints.ToString();
    }
}
