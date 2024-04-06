using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;

public class Creature : MonoBehaviour
{
    [SerializeField] private int _maxHp;
    [SerializeField] private int _hp;
    private ObjectPool<Creature> _pool;

    public void Update()
    {
        _hpCheck();
    }

    public void Activate()
    {
        _hp = _maxHp;
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

    private void _hpCheck()
    {
         if (_hp < 0)
        {
            Deactivate();
        }
    }
    
    public void SetPool(ObjectPool<Creature> pool)
    {
        this._pool = pool;
    }
}
