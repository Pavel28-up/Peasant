using System;
using UnityEngine;

// Скрипт событий игры
public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    // event - событие Action - delegat
    public event Action OnButton;
    public event Action<float> OnValueMusic;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
    }

    public void InvokeButton()
    {
        Debug.Log("event");
        OnButton?.Invoke();
    }

    public void InvokeValueMusic(float value)
    {
        OnValueMusic?.Invoke(value);
    }
}
