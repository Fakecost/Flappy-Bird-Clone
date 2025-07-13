using UnityEngine;

public class PipeOutOfFrame : MonoBehaviour
{
    
    [SerializeField] Pipe pipe;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OutOfFrame"))
        {
           pipe.ReturnToPool();
        }
    }
}
