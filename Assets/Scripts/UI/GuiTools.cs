using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiTools : MonoBehaviour
{
    public void LoadScene()
    {
        GameEvents.Instance.InvokeButton();
        SceneController.NextScene();
    }

    public void LoadScene(int id)
    { 
        GameEvents.Instance.InvokeButton();
        SceneController.NextScene(id);
    }
}
