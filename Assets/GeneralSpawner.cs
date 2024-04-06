using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class GeneralSpawner : MonoBehaviour
{
    [SerializeField] private int index;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public IEnumerator SpawnIEnumerator()
    {
        yield return new WaitForSeconds(0);
    }

    public void Spawn(int index)
    {
        var data = CreatureDataBase.instance.CreatureDatas[index];
        var prefab = data.Prefab;
        var pool = data.Pool;
        var c = data.Pool.Get();

        c.SetPool(data.Pool);
        c.Activate();
    }
}
