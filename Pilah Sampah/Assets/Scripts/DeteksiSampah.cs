using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    // Called before the first update frame
    void Start()
    {
        //Add audio source and assign it to MediaPlayerBenar
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();

        //Assign audioBenar as MediaPlayerBenar's clip 
        MediaPlayerBenar.clip = audioBenar;

        //Add audio souce and assign it to MediaPlayerSalah
        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();

        //Assign audioSalah as MediaPlayerSalah's clip
        MediaPlayerSalah.clip = audioSalah;
    }

    //Check object entering trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the object tag is the same with nameTag
        if (collision.tag.Equals(nameTag))
        {
            //Increase score by 10
            Data.score += 10;

            //Display the score
            textScore.text = Data.score.ToString();

            //Destroy the trash object
            Destroy(collision.gameObject);

            //Play the MediaPlayerBenar sound
            MediaPlayerBenar.Play();

        //If it's not the same
        } else
        {
            //Decrease score by 15
            Data.score -= 15;

            //Display the score
            textScore.text = Data.score.ToString();

            //Destroy the trash object
            Destroy(collision.gameObject);

            //Play the MediaPlayerSalah sound
            MediaPlayerSalah.Play();
        }
    }
}
