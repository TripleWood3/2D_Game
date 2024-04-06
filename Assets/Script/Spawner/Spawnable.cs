using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;

public class Spawnable : MonoBehaviour
{
    private ObjectPool<Spawnable> _pool;
    public void Activate()
    {
        this.gameObject.SetActive(true);
    }
    public void Activate(Vector2 pos)
    {
        Activate();
        this.transform.position = pos;
    }
    public void Deactivate()
    {
        this.gameObject.SetActive(false);
        _pool.Release(this);
    }
    public void SetPool(ObjectPool<Spawnable> pool)
    {
        this._pool = pool;
    }
}
