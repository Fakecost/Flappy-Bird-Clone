using System.Collections.Generic;
using UnityEngine;

public class PipeObjectPooling : MonoBehaviour
{
    [SerializeField] Pipe pipePrefab;
    [SerializeField] int initialSizePool = 5;
  
    private Queue<GameObject> spawnQueue = new Queue<GameObject>();
    private void Awake()
    {
        for (int i = 0; i < initialSizePool; i++)
        {
           var ob = CreatePipe();
           ob.gameObject.name = "Pipe" + i;
        }
    }

    public GameObject CreatePipe()
    {
        Pipe obj = Instantiate(pipePrefab);
        
        obj.Setup(this);
        obj.gameObject.SetActive(false);
        spawnQueue.Enqueue(obj.gameObject);
        return obj.gameObject;
    }

    public GameObject Spawn()
    {
        if (spawnQueue.Count == 0)
        {
            CreatePipe();
        }
        
        GameObject obj = spawnQueue.Dequeue();
        obj.SetActive(true);
      
        return obj;
    }
    
    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        Debug.Log(obj.gameObject.name,gameObject);
        spawnQueue.Enqueue(obj);
    }
  
}
