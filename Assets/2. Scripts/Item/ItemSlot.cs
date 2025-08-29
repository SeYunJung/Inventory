using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    private ItemData _itemData;
    private GameObject _equipImage;

    public void SetItemData(ItemData itemData)
    {
        _itemData = itemData;
    }

    public void GetEuqipImage(GameObject equipImage)
    {
        _equipImage = equipImage;
    }

    public void OnSlotBtnClicked()
    {
        // isEquip�� true, false�� 
        if (_itemData.isEquip) _itemData.isEquip = false;
        else _itemData.isEquip = true;

        // ������Ʈ�� Ȱ��ȭ, ��Ȱ��ȭ
        if (_itemData.isEquip) _equipImage.SetActive(false);
        else _equipImage.SetActive(true);
    }
}
