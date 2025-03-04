using System;
using UnityEngine;

// ������ ������� ����
public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    // event - ������� Action - delegat
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
