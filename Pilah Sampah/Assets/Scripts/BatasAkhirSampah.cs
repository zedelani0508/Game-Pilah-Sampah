using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour
{

    //Check if any object entering trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy the game object
        Destroy(collision.gameObject);

        //Load Game Over Scene
        SceneManager.LoadScene("GameOver");
    }
}
