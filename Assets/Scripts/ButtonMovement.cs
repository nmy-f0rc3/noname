using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

 
public class ButtonMovement : Button
{
    

    private AbstractMoveScript moveScript;


    private new void  Awake()
    {
        moveScript = GetComponent<AbstractMoveScript>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Application.IsPlaying(this) && moveScript != null)
            moveScript.UpdateState(IsPressed());
    }
    
}
