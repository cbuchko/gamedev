using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("In my inventory: " + inventory);
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Calculates where the new position would be and only moves there if it is inside the playing area
        Vector2 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        if(newPosition.x < 8.8 && newPosition.x > -8.8 && newPosition.y > -4.5 && newPosition.y < 4.5){
            rb.MovePosition(newPosition);
        }

    }
}
