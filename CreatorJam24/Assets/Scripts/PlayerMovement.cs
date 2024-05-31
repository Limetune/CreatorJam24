using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovementScript : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    Vector2 movedirection;

    bool lookRight = true;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        movedirection = new Vector2(moveX, moveY).normalized;
        //flip(moveX);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movedirection.x * movementSpeed, movedirection.y * movementSpeed);
    }

    void flip(float moveX)
    {
        if ((moveX > 0 && lookRight == false) || (moveX < 0 && lookRight == true))
        {
            transform.Rotate(0f, 180f, 0f);
            lookRight = !lookRight;
        }
    }
}