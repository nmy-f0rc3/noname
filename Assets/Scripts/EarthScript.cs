using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript : MonoBehaviour
{
    public PlayerScripts Player;
    public EnemyScript Enemy;
    private void OnTriggerEnter(Collider HitScan)
    {
        EnemyScript enemy = HitScan.GetComponent<EnemyScript>();
        if (enemy != null)
        {
            Player.TakeDamage(3);
        }
    }
}
