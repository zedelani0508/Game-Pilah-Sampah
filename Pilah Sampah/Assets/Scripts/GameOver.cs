using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        //Timer will increase by delta time
        timer += Time.deltaTime;

        //If timer greater than 2
        if(timer > 2)
        {
            //Reset score
            Data.score = 0;

            //Load Gameplay scene
            SceneManager.LoadScene("Gameplay");
        }
    }
}
