using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarterMotoblock : MonoBehaviour
{
    public Slider starter;

    public float starterAmount;
    public float secondsStarter;

    private void Start()
    {
        starter = GetComponent<Slider>();

    }

    public void OnChangedStarter()
    {
        starterAmount = starter.value;
        CancelInvoke();
        if (starterAmount > 0)
        {
            InvokeRepeating(nameof(StarterTime), 0, 0);
        }
    }

    void StarterTime()
    {
        Debug.Log(starterAmount);
        if (starterAmount > 0)
        {
            //starter.interactable = false;
            starterAmount -= 100 / secondsStarter * Time.deltaTime;
            starter.value = starterAmount;
        }
        else
        {
            starterAmount = 0;
            //starter.interactable = true;
            CancelInvoke();
        }
    }
}
