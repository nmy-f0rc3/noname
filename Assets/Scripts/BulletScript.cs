using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float BulletSpeed;
    public Rigidbody BulletBody;

    


    // Start is called before the first frame update
    void Start()
    {

        BulletBody.velocity = transform.forward * BulletSpeed;
    }

    
    private void OnTriggerEnter(Collider HitScan)
    {
        EnemyScript enemy = HitScan.GetComponent<EnemyScript>();
        if(enemy != null)
        {
            enemy.TakeDamage(1);
            Destroy(gameObject);
        }
        BossScript Boss = HitScan.GetComponent<BossScript>();
        if (Boss != null)
        {
            Boss.TakeDamage(1);
            Destroy(gameObject);
        }
        EarthScript Wall = HitScan.GetComponent<EarthScript>();
        if (Wall != null)
        {
            Destroy(gameObject);
        }
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
