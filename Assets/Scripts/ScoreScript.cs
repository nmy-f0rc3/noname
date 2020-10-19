using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public Canvas MainMenu;
    public Canvas ScoreMenu;

    public void Score()
    {
        MainMenu.gameObject.SetActive(false);
        ScoreMenu.gameObject.SetActive(true);

    }
    public void ExitScore()
    {
        MainMenu.gameObject.SetActive(true);
        ScoreMenu.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
