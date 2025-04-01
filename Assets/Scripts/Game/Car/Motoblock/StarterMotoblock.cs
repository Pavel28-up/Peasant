using UnityEngine;
using UnityEngine.UI;

public class StarterMotoblock : MonoBehaviour
{
    public Slider starter;

    public float starterAmount;
    public float secondsStarter;
    public bool broken;

    private void Start()
    {
        starter = GetComponent<Slider>();

    }

    public void OnChangedStarter()
    {
        starterAmount = starter.value;

        if (!broken)
        {
            if (starterAmount > 0)
            {
                InvokeRepeating(nameof(StarterTime), 0, 0);
            }
        }
        else
        {
            starter.interactable = false;
        }
    }

    void StarterTime()
    {
        if (starterAmount > 0)
        {
            starter.interactable = false;
            starterAmount -= 100 / secondsStarter * Time.deltaTime;
            starter.value = starterAmount;
            if (starterAmount == 0)
            {
                starter.interactable = true;
                CancelInvoke();
            }
        }
    }
}
