using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _isPlaying = false;
    public static GameManager instance;

    void Awake()
    {
        instance = this;
        _isPlaying = false;
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        _isPlaying = true;
    }
}