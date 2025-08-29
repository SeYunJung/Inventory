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
        // 인벤토리 창 끄기
        gameObject.SetActive(false);

        // 메인 UI 키기
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
        // 아이템 슬롯 생성, 슬롯에 아이템 세팅 
        foreach(ItemData item in _itemDictionary.Keys)
        {
            GameObject go = Instantiate(slotPrefab, contentTransform);

            GameObject go2 = Instantiate(item.itemPrefab, go.transform);
            if (!_itemDictionary[item]) // 장착템이 아니면 
            {
                // 장착 표시
                go2.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
