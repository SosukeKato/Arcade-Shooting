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
    /// PoolからObjectを取得
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
            Debug.LogWarning("足りなかったから仕方ないし作ってやるやで");
        }

        prefab.SetActive(true);

        return prefab;
    }

    /// <summary>
    /// PoolにObjectを返却
    /// </summary>
    /// <param name="index"></param>
    /// <param name="prefab"></param>
    void ReturnObject(int index, GameObject prefab)
    {
        if (prefab == null)
        {
            return;
        }

        if (index < 0 || index >= _pdArray[index].pool.Count)
        {
            Debug.LogError($"インデックス{index}が範囲外までいっちゃったやでどうするやで？");
            return;
        }

        prefab.SetActive(false);
        prefab.transform.SetParent(_parent);
        _pdArray[index].pool.Enqueue(prefab);
    }
}
