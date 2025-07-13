using System;
using Unity.VisualScripting;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rigidbody2D;
    
    private PipeObjectPooling pipeObjectPooling;


    public void Setup(PipeObjectPooling pipeObjectPooling)
    {
        this.pipeObjectPooling = pipeObjectPooling;
    }

    private void OnEnable()
    {
        rigidbody2D.linearVelocity = Vector2.left * speed;
    }

    public void ReturnToPool()
    {
            pipeObjectPooling.ReturnToPool(gameObject);
        
    }
}
