using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IPointerDownHandler
{
    public ItemScriptableObject item;
    public InventoryInfo info;
    public TMP_Text itemAmountText;
    public Image icon;
    public int amount;
    public string namePanel = "InventoryInfo";

    public bool isEmpty = true;

    private void Start()
    {
        namePanel = "InventoryInfo";
        icon = transform.GetChild(0).GetComponent<Image>();
        itemAmountText = transform.GetChild(1).GetComponent<TMP_Text>();
        info = GameObject.Find(namePanel).GetComponent<InventoryInfo>();
    }

    public void SetIcon(Sprite _icon)
    {
        icon.color = new Color(1, 1, 1, 1);
        icon.sprite = _icon;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        info.Info(item);
    }
}
