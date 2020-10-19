using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class MenuScript : MonoBehaviour
{
    
    

    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene("Menu");
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
