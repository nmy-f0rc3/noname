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
                SpawnSodomit(x, 5.45f, z, Color.blue); 
            }
        
            for (int z = 9; z < 11; z++)
            {
                SpawnSodomit(x, 5.45f, z, Color.green);
            }
            for (int z = 11; z < 13; z++)
            {
                SpawnSodomit(x, 5.45f, z, Color.red);
            }
        }

        var boss = Instantiate(Boss, new Vector3(-3, 0.8f, 16), Quaternion.identity);
                boss.GetComponent<BossScript>().Player = Player;
                boss.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.cyan);

    }

    private GameObject SpawnSodomit(float x, float y, float z, Color color)
    {
        var sodomit = Instantiate(EnemyShip, new Vector3(x, y, z), Quaternion.identity);
        sodomit.GetComponent<EnemyScript>().Player = Player;
        sodomit.GetComponent<MeshRenderer>().material.SetColor("_Color", color);
        return sodomit;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
