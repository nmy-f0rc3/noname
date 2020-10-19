using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScripts : MonoBehaviour
{
    public Transform RocketPoint;
    public GameObject Rocket;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0, 1);
    }

    // Update is called once per frame

    void Shoot()
    {
        GameObject RocketInstance = Instantiate(Rocket, RocketPoint.position, RocketPoint.rotation);
        RocketInstance.GetComponent<Rigidbody>().AddForce(RocketPoint.forward * 5, ForceMode.Impulse);
    }
}
