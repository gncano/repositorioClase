using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
   
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            Debug.Log("Quit requested");
            Application.Quit();
        }
    }
}
