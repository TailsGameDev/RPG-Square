using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private GameObject attackCollider;

    private void Update()
    {
        bool clicked = Input.GetButtonDown("Fire1");
        if (clicked)
        {
            Instantiate(attackCollider, Vector3.up + transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical).normalized;

        rb2d.AddForce(direction * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    }
}
