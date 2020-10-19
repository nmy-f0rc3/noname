﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public int Health;
    public float PlayerVelocity;
    public float Boundary;
    public int PlayerPoints;
    public GameObject Player;
    public Canvas MainMenu;

    public float Movement
    {
        get { return MovesLeft ? -1f : MovesRight ? 1f : 0f; }
    }

    public bool MovesLeft { get; set; } = false;
    public bool MovesRight { get; set; } = false;
    

    private Vector3 playerPosition;

    

    // Start is called before the first frame update

    public void TakeDamage(int Damage)
    {
       
        Health -= Damage;
        if (Health <= 0)
        {
            Die();
        }

    }
    public void Die()
    {
        if (PlayerPrefs.GetInt("Score") < PlayerPoints)
        {
            PlayerPrefs.SetInt("Score", PlayerPoints);
        }
        SaveScoreScript.AddScore(PlayerPoints);

        Time.timeScale = 0;
        MainMenu.gameObject.SetActive(true);

    }

    void Start()
    {
        PlayerPoints = 0;
        playerPosition = gameObject.transform.position;
    }

    public void AddPoints(int points)
    {
        PlayerPoints += points;
    }




    // Update is called once per frame
    void Update()
    {
        float newX = playerPosition.x + Movement * PlayerVelocity;

        newX = Mathf.Clamp(newX, -Boundary, Boundary);

        transform.position = playerPosition = new Vector3(newX, playerPosition.y, playerPosition.z);

    }


}

