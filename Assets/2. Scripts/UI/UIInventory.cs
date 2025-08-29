using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button _backBtn;
    [SerializeField] private TMP_Text _capacityText;

    private Player _player;
    private Dictionary<ItemData, bool> _itemDictionary;

    public Transform contentTransform;
    public GameObject slotPrefab;

    private void Start()
    {
        _backBtn.onClick.AddListener(OnBackBtnClicked);

        Init();

        SetCapacity();

        SetSlot();
    }

    public void OnBackBtnClicked()
    {
        // �κ��丮 â ����
        gameObject.SetActive(false);

        // ���� UI Ű��
        UIManager.Instance.SetActive("Main");
    }

    private void Init()
    {
        _player = GameManager.Instance.Player;
        _itemDictionary = _player.ItemDictionary;
    }

    private void SetCapacity()
    {
        _capacityText.text = $"{_itemDictionary.Keys.Count} / 120";
    }

    private void SetSlot()
    {
        // ������ ���� ����, ���Կ� ������ ���� 
        foreach(ItemData item in _itemDictionary.Keys)
        {
            GameObject go = Instantiate(slotPrefab, contentTransform);
            go.GetComponent<ItemSlot>().SetItemData(item);

            GameObject go2 = Instantiate(item.itemPrefab, go.transform);
            go.GetComponent<ItemSlot>().GetEuqipImage(go2.transform.GetChild(1).gameObject);
            if (!_itemDictionary[item]) // �������� �ƴϸ� 
            {
                // ���� ǥ��
                go2.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
