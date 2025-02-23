using UnityEngine;

// ������ ���� � �������� ��������� ����������
public class Menu : MonoBehaviour
{
    public string menuName;
    public bool isOpened;

    public void Open()
    {
        isOpened = true;
        gameObject.SetActive(isOpened);
    }

    public void Close()
    {
        isOpened = false;
        gameObject.SetActive(isOpened);
    }
}
