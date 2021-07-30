using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{

    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;


    // Update is called once per frame
    void Update()
    {
        //Increase timer by delta time
        timer += Time.deltaTime;

        //If timer greater than jeda
        if(timer > jeda)
        {
            //Randomize number from 0 to obyekSampah length
            int random = Random.Range(0, obyekSampah.Length);
            
            //Instantiate the random object
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
            
            //Set the timer back to 0
            timer = 0;
        }
    }
}
