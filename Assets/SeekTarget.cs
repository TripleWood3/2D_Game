using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekTarget : SteerBehaviour2D
{
    [SerializeField] private float _maxVelocity = 10;
    [SerializeField] private float _searchRange = 10;
    private Rigidbody2D _rigidbody2D;

    public void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public override Vector2 Output()
    {
        var colliders = Physics2D.OverlapCircleAll(transform.position, _searchRange);
        Vector2 target = Vector2.zero;

        if(colliders.Length > 0)
           target = colliders[0].transform.position;

        var desired = target - (Vector2)transform.position;
        desired = desired.normalized * _maxVelocity;
        var steering = desired - _rigidbody2D.velocity;

        return steering;
    }
}
