using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DieRecord : MonoBehaviour
{
    public Text MyScore;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Points = GameObject.Find("Player");
        PlayerScripts Player = Points.GetComponent<PlayerScripts>();
        int MyPoints = Player.PlayerPoints;
        MyScore.text = MyPoints.ToString();
    }
}
