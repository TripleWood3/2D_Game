using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public int Hp { get;}
    public int MaxHp { get;}
    public void Set(int hp);
}

