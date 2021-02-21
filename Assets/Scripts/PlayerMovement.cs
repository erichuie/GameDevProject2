using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    float verticalMove;
    float horizontalMove;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxisRaw("Vertical");
        horizontalMove = Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate(){
        rb.velocity = new Vector2(horizontalMove * speed, verticalMove * speed);
    }
}
