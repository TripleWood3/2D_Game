using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour, ITeamable, IDamageable
{
    [SerializeField] private int _hp;
    [SerializeField] private int _maxHp;
    public int Hp { get => _hp;}
    public int MaxHp { get => _maxHp;}
    public void Set(int hp)
    {
        _hp = Mathf.Clamp(hp, 0, _maxHp);
    }

    void Start()
    {

    }
    void Update()
    {

    }
}
