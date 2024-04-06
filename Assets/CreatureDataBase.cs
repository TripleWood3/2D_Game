using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class CreatureDataBase : MonoBehaviour
{
    public static CreatureDataBase instance;
    [SerializeField] private List<CreatureData> _creatureDatas;
    
    void Start()
    {
        instance = this;
    }

    void Update()
    {
           
    }
    public List<CreatureData> CreatureDatas => _creatureDatas;

    private void _release()
    {
        foreach(var d in _creatureDatas)
        {
            foreach(var m in )
            data.Pool.Release();
        }
    }
}

[Serializable]
public class CreatureData
{
    [SerializeField] private Creature _prefab;
    [SerializeField] private List<Creature> _member;
    [SerializeField] private ObjectPool<Creature> _pool;

    public Creature Prefab => _prefab;
    public List<Creature> Member => _member;
    public ObjectPool<Creature> Pool => _pool;
}