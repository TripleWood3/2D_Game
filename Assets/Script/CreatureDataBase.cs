using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class CreatureDataBase : MonoBehaviour
{
    public static CreatureDataBase instance;
    [SerializeField] private List<Creature> _prefabs;
    [SerializeField] private List<ObjectPool<Creature>> _pools;
    
    void Awake()
    {
        if (instance != null)
            Debug.Log("Duplicate CreatureDataBase");

        instance = this;
        _pools = new List<ObjectPool<Creature>>();
        for(int i = 0; i < _prefabs.Count; i++)
        {
            var n = i;
            _pools.Add(new ObjectPool<Creature>(() => Instantiate(_prefabs[n])));
        }
    }

    public List<ObjectPool<Creature>> Pools => _pools;
}