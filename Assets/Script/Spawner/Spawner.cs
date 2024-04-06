using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _index;
    [SerializeField] private int _number;
    [SerializeField] private float _interval;

    void Start()
    {
        var c = StartCoroutine(SpawnIEnumerator());
    }

    public IEnumerator SpawnIEnumerator()
    {
        for(int i = 0; i < _number; i++)
        {
            yield return new WaitForSeconds(_interval);
            Spawn(_index);
        }
    }

    public void Spawn(int index)
    {
    
        var p = SpawnDataBase.instance.Pools[index];
        var c = p.Get();
        c.SetPool(p);
        c.Activate(transform.position);

    }
}
