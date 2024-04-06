using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnDataBase : MonoBehaviour
{
    public static SpawnDataBase instance;
    [SerializeField] private List<Spawnable> _prefabs;
    [SerializeField] private List<ObjectPool<Spawnable>> _pools;
    
    void Awake()
    {
        if (instance != null)
            Debug.Log("Duplicate CreatureDataBase");

        instance = this;
        _pools = new List<ObjectPool<Spawnable>>();
        for(int i = 0; i < _prefabs.Count; i++)
        {
            var n = i;
            _pools.Add(new ObjectPool<Spawnable>(() => Instantiate(_prefabs[n])));
        }
    }

    public List<ObjectPool<Spawnable>> Pools => _pools;
}