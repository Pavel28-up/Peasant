using Game.Types;
using System.Collections.Generic;
using UnityEngine;

public class CarScriptableObject : ScriptableObject
{
    public CarType carType;

    public List<SparePart> spareParts;

    public GameObject itemPrefab;
    public Sprite icon;

    public string carName;
    public string carDescription;
}

[System.Serializable]
public class SparePart
{
    public ItemScriptableObject item;
    public int amount;
}
