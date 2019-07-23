using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    float speed = 7.0f;
    Rigidbody2D rigidbody;
    Vector3 movement;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);

        if (GameControl.isGameOver)
        {
            this.enabled = false;
        }
    }

    void Move(float h, float v)
    {
        movement.Set(h, v, 0f);
        movement = movement.normalized * speed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + movement);
    }
}
