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
        PlayerPrefs.SetInt("SceneID", id);
        // �������� ����� �� �������
        SceneManager.LoadScene(0);
    }

    // ���������� ����� ��������� ��������� ����� �� �������
    public static void NextScene(int id)
    {
        PlayerPrefs.SetInt("SceneID", id);
        // �������� ����� �� �������
        SceneManager.LoadScene(0);
    }
}
