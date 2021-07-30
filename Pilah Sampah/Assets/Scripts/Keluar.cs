using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //If the escape button pressed
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            //Quit the game
            Application.Quit();
        }
    }
}
