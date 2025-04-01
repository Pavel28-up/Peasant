using UnityEngine;
using UnityEngine.SceneManagement;

// Скрипт для управления состоянием сцен
public class SceneController : MonoBehaviour
{
    // Метод перезагрузки активной сцены
    public static void Restart()
    {
        // Получение индекса активной сцены
        int id = SceneManager.GetActiveScene().buildIndex;
        // Закрузка сцены по индексу
        SceneManager.LoadScene(id);
    }


    // Метод закгрузки следующей сцены
    public static void NextScene()
    {
        // Получение индекса активной сцены
        int id = SceneManager.GetActiveScene().buildIndex;
        // Увелечение индекса на 1
        id++;
        PlayerPrefs.SetInt("SceneID", id);
        // Закрузка сцены по индексу
        SceneManager.LoadScene(0);
    }

    // Перегрузка метод закгрузки следующей сцены по индексу
    public static void NextScene(int id)
    {
        PlayerPrefs.SetInt("SceneID", id);
        // Закрузка сцены по индексу
        SceneManager.LoadScene(0);
    }
}
