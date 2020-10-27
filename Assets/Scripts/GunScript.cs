using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GunScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

	public Transform BullPoint;
    public GameObject Bullet;
        
    public bool cooldown = false;

    public bool isDown = false;

    public void Update()
    {
        if (Input.GetButton("Jump") && (cooldown == false))
        {
            cooldown = true;            
            Fire();
            Invoke("ResetCooldown", 0.1f);
        }

    }

    public void ResetCooldown()
    {
        cooldown = false;
    }
   public void Fire()
    {
        
        Instantiate(Bullet, BullPoint.position, BullPoint.rotation);
        
    }


    
    public void OnPointerDown(PointerEventData eventData)
    {
        if (cooldown == false)
        {
            isDown = true;
            FireAndCooldown();
            
        }

    }

    private void FireAndCooldown()
    {
        cooldown = false;
        if (!isDown)
            return;

        Fire();
        Invoke("FireAndCooldown", 1.0f);
        cooldown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
        
    }
}



