using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScripts : MonoBehaviour
{
    //public Transform RocketPoint;
    //public GameObject Rocket;

    public Transform SpawnTransform;
    public Transform TargetTransform;

    public float AngleInDegrees;

    float g = Physics.gravity.y;

    public GameObject Bullet;
    private bool fire = true;
    private float Xsec = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Shot", 0, Xsec);
    }

    // Update is called once per frame


    void Update()
    {
        SpawnTransform.localEulerAngles = new Vector3(-AngleInDegrees, 0f, 0f);

        Vector3 fromTo = TargetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;

        float AngleInRadians = AngleInDegrees * Mathf.PI / 180;
        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));
        if (fire == true)
        {
            GameObject newBullet = Instantiate(Bullet, SpawnTransform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody>().velocity = SpawnTransform.forward * v;
            fire = false;
        }




        //GameObject RocketInstance = Instantiate(Rocket, RocketPoint.position, RocketPoint.rotation);
        //RocketInstance.GetComponent<Rigidbody>().AddForce(RocketPoint.forward * 5, ForceMode.Impulse);
    }

    public void Shot()
    {
        fire = true;
    }

}
