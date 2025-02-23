using System.Collections;
using System.Collections.Generic;
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
        // Закрузка сцены по индексу
        SceneManager.LoadScene(id);
    }

    // Перегрузка метод закгрузки следующей сцены по индексу
    public static void NextScene(int id)
    {
        // Закрузка сцены по индексу
        SceneManager.LoadScene(id);
    }

    // Перегрузка метод закгрузки следующей сцены по имени
    public static void NextScene(string nameScene)
    {
        // Закрузка сцены по индексу
        SceneManager.LoadScene(nameScene);
    }
}
