using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolData
{
    public GameObject prefab;
    public Transform[] activePosition;
    public List<GameObject> objectList = new();
    public Queue<GameObject> pool = new();
    public int poolSize;
}

public class ObjectPool : MonoBehaviour
{
    [SerializeField] PoolData[] _pd;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
