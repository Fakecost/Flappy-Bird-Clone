using System;
using UnityEngine;

public class PipeScore : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore();
            
        }
    }
}
