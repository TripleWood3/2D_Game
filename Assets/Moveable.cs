using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEditor.AdaptivePerformance.Editor;
using System.Linq;
using UnityEngine.UIElements;

public class Moveable : MonoBehaviour
{
    private List<SteerBehaviour2D> _steers;
    private Rigidbody2D _rigidbody2D;

    public void Awake()
    {
        _steers = gameObject.GetComponents<SteerBehaviour2D>().ToList();
    }

    public void FixedUpdate()
    {
        var totalForce = new Vector2 (0, 0);
        var totalWeight = 0;
        foreach(var s in _steers) {
            totalWeight += s.Weight; 
        }

        if (totalWeight < 0)
            Debug.Log("totalWeight 0");

        foreach(var s in _steers) {
            totalForce += s.Output() * s.Weight / totalWeight;
        }

        _rigidbody2D.AddForce(totalForce);    
    }
}