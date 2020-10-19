using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TableScore : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
       GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
