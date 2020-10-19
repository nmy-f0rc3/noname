using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public float RocketSpeed;
    public Rigidbody RocketBody;

    // Start is called before the first frame update
    void Start()
    {
        RocketBody.velocity = transform.forward * RocketSpeed;
    }


    private void OnTriggerEnter(Collider HitScan)
    {
        PlayerScripts Player = HitScan.GetComponent<PlayerScripts>();
        if (Player != null)
        {
            Player.TakeDamage(1);
            Destroy(gameObject);
        }
        EnemyScript ground = HitScan.GetComponent<EnemyScript>();
        if (ground != null)
        {
            Destroy(gameObject);
        }

    }

}
