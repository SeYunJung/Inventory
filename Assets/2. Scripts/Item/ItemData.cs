using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]
public class ItemData : ScriptableObject
{
    public GameObject itemPrefab;
    public bool isEquip;
}
