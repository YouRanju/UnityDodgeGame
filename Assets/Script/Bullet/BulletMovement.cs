using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public Transform target;
    public float speed = 5f;
    public float rotateSpeed;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rotateSpeed = Random.Range(5f, 200f);
    }

	void FixedUpdate () {
        if (GameControl.isGameStart)
        {
            Vector2 direction = (Vector2)target.position - rb.position;

            direction.Normalize();

            float rotateAmount = Vector3.Cross(direction, transform.up).z;

            rb.angularVelocity = -rotateAmount * rotateSpeed;

            rb.velocity = transform.up * speed;
        }

        if (GameControl.isGameOver)
        {
            this.enabled = false;
        }
    }
}
