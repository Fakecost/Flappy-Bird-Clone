using System;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float velocity = 1.5f;

    [SerializeField] private UnityEvent onJump;
    
    public void Jump()
    {
        rigidbody2D.linearVelocity = Vector2.up * velocity;
        onJump.Invoke();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Jump();
        }
    }
}
