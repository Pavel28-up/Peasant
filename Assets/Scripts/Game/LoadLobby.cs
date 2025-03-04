using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLobby : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image loadBar;
    public TMP_Text barTxt;
    public int sceneId;

    private float progress;

    private void Start()
    {
        // PlayerPrefs.SetInt("SceneID", 0);
        if (PlayerPrefs.HasKey("SceneID"))
            sceneId = PlayerPrefs.GetInt("SceneID");
        else
            sceneId = 1;
        StartCoroutine(LoadSceneCorId());
    }

    private void Update()
    {
        barTxt.text = "Загрузка: " + Mathf.FloorToInt(progress * 100) + "%";
    }


    IEnumerator LoadSceneCorId()
    {
        yield return new WaitForSeconds(1f);
        asyncOperation = SceneManager.LoadSceneAsync(sceneId);
        while (!asyncOperation.isDone)
        {
            progress = asyncOperation.progress / 0.9f;
            loadBar.fillAmount = progress;
            barTxt.text = "Loading: " + Mathf.FloorToInt(progress * 100) + "%";
            yield return 0;
        }
    }
}
