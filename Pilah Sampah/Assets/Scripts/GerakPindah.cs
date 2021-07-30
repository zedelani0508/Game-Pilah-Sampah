using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindah : MonoBehaviour
{

    float speed = 3f;
    public Sprite[] sprites;

    // Use this for initialization
    void Start()
    {
        //Randomize sprite will be assigned into game object sprite renderer
        int index = Random.Range(0, sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        //Move game object to left by speed
        float move = (speed * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector3(move, transform.position.y);
    }

    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;

    //Mouse click the game object
    void OnMouseDown()
    {
        //Assign game object initial Y position
        firstY = transform.position.y;

        //Assign game object screen position
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        
        //Assign mouse offset
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }


    //Mouse dragging object
    void OnMouseDrag()
    {
        //Assign game object to mouse position
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    //Mouse release object
    private void OnMouseUp()
    {
        //Drop the game object on the initial Y position
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
    }

}
