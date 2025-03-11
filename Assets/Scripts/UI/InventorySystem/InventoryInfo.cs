using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryInfo : MonoBehaviour
{
    Image icon;
    TMP_Text nameText;
    TMP_Text descriptionText;
    TMP_Text wearAndTearText;

    private void Start()
    {
        icon = transform.GetChild(0).GetComponent<Image>();
        nameText = transform.GetChild(1).GetComponent<TMP_Text>();
        descriptionText = transform.GetChild(2).GetChild(0).GetChild(0).GetChild(1).GetComponent<TMP_Text>();
        wearAndTearText = transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetComponent<TMP_Text>();
    }

    public void Info(ItemScriptableObject item)
    {
        icon.sprite = item.icon;
        nameText.text = $"{item.itemName}";
        descriptionText.text = $"Описание: {item.itemDescription}";
        wearAndTearText.text = $"Износ: \"В разработке\"";
    }
}
