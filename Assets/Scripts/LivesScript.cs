using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{
    public Text MyLive;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Health = GameObject.Find("Player");
        PlayerScripts Player = Health.GetComponent<PlayerScripts>();
        int MyLives = Player.Health;
        MyLive.text = "Live:" + MyLives.ToString();
    }
}
