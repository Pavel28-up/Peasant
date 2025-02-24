using System;
using UnityEngine;

// Скрипт событий игры
public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    public event Action OnButton;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
    }

    public void InvokeButton()
    {
        OnButton?.Invoke();
    }
}
