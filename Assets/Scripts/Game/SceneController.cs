using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ������ ��� ���������� ���������� ����
public class SceneController : MonoBehaviour
{
    // ����� ������������ �������� �����
    public static void Restart()
    {
        // ��������� ������� �������� �����
        int id = SceneManager.GetActiveScene().buildIndex;
        // �������� ����� �� �������
        SceneManager.LoadScene(id);
    }


    // ����� ��������� ��������� �����
    public static void NextScene()
    {
        // ��������� ������� �������� �����
        int id = SceneManager.GetActiveScene().buildIndex;
        // ���������� ������� �� 1
        id++;
        // �������� ����� �� �������
        SceneManager.LoadScene(id);
    }

    // ���������� ����� ��������� ��������� ����� �� �������
    public static void NextScene(int id)
    {
        // �������� ����� �� �������
        SceneManager.LoadScene(id);
    }

    // ���������� ����� ��������� ��������� ����� �� �����
    public static void NextScene(string nameScene)
    {
        // �������� ����� �� �������
        SceneManager.LoadScene(nameScene);
    }
}
