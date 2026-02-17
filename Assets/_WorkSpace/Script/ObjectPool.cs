using System.Collections.Generic;
using TMPro.EditorUtilities;
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

public enum PoolType
{
    
}

public class ObjectPool : MonoBehaviour
{
    [SerializeField] PoolData[] _pdArray;
    [SerializeField] Transform _parent;

    /// <summary>
    /// Pool‚©‚çObject‚ğæ“¾
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    GameObject GetObject(int index)
    {
        GameObject prefab;

        if (_pdArray[index].pool.Count > 0)
        {
            prefab = _pdArray[index].pool.Dequeue();
        }
        else
        {
            prefab = Instantiate(_pdArray[index].prefab);
            prefab.transform.SetParent(_parent);
            _pdArray[index].objectList.Add(prefab);
            Debug.LogWarning("‘«‚è‚È‚©‚Á‚½‚©‚çd•û‚È‚¢‚µì‚Á‚Ä‚â‚é‚â‚Å");
        }

        prefab.SetActive(true);

        return prefab;
    }
}
