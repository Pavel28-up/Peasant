using UnityEngine;

// Скрипт меню с методами включения выключения
public class Menu : MonoBehaviour
{
    public string menuName;
    public bool isOpened;

    public void Open()
    {
        isOpened = true;
        gameObject.SetActive(isOpened);
        GameEvents.Instance.InvokeButton();
    }

    public void Close()
    {
        isOpened = false;
        gameObject.SetActive(isOpened);
    }
}
