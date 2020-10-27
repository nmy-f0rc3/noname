using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{

    public GameObject EnemyShip;
    public GameObject Boss;
    public PlayerScripts Player;




    void Start()
    {
        for (int x = -3; x < 3; x++)
        {
            for (int z = 8; z < 9; z++)
            {
                //var sodomit = Instantiate(EnemyShip, new Vector3(x, 0.45f, z), Quaternion.identity);
                //sodomit.GetComponent<EnemyScript>().Player = Player;
                //sodomit.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
                SpawnSodomit(x, 5.45f, z, Color.blue, EnemyScript.State.Fly, 2, 10, Player);
            }

            for (int z = 9; z < 11; z++)
            {
                SpawnSodomit(x, 5.45f, z, Color.green, EnemyScript.State.Fly, 2, 10, Player);
            }
            for (int z = 11; z < 13; z++)
            {
                SpawnSodomit(x, 5.45f, z, Color.red, EnemyScript.State.Fly, 2, 10, Player);
            }
        }

        //var boss = Instantiate(Boss, new Vector3(-3, 0.8f, 16), Quaternion.identity);
        //boss.GetComponent<BossScript>().Player = Player;
        //boss.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.cyan);

    }

    private void SpawnSodomit(float x, float y, float z, Color color, EnemyScript.State state, int HP, int Point, PlayerScripts player)
    {
        var sodomit = Instantiate(EnemyShip, Vector3.zero, Quaternion.identity)
            .GetComponent<EnemyScript>();

        sodomit.Init(x, y, z, color, state, HP, Point, player);
    }

    // Update is called once per frame
    void Update()
    {


    }
}