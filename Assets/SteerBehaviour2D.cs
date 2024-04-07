using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerBehaviour2D : MonoBehaviour
{
    private int _weight = 1;
    public virtual Vector2 Output()
    {
        return new Vector2(0, 0);
    }
    public int Weight => _weight;
}
