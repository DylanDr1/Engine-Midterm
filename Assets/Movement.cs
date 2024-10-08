using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Movement : MonoBehaviour
{
    Rigidbody2D playerBody;

    [SerializeField]
    float moveSpeed;

    [SerializeField]
    float maxPos;
    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
            Move();

        if(Input.GetKey(KeyCode.Space))
        {
            Sound();
        }
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            playerBody.AddForce(moveSpeed * transform.right, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            playerBody.AddForce(moveSpeed * transform.right, ForceMode2D.Force);
        }

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }


    private void Sound()
    {
      //Blaster.mp3
    }
}
