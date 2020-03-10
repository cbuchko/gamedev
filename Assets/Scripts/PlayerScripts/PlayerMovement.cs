using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    float inputSet = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Calculates where the new position would be and only moves there if it is inside the playing area
        Vector2 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
        // if(newPosition.x < 8.8 && newPosition.x > -8.8 && newPosition.y > -4.5 && newPosition.y < 4.5){
        //     
        // }
        Vector2 zeroVector = new Vector2(0,0);
        if(movement != zeroVector){
            inputSet = 1;
        }else{
            inputSet = 0;
        }
        rb.MovePosition(newPosition);
        Animate();

    }

    void Animate()
    {
        if(movement != Vector2.zero){
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Walk", inputSet);
        }else{
            animator.SetFloat("Walk", 0);
        }

    }
}
