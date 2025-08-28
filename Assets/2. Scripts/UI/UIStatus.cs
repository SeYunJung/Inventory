using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TMP_Text _attackText;
    [SerializeField] private TMP_Text _defenseText;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _criticalText;

    [SerializeField] private Button _backBtn;

    private void Start()
    {
        _backBtn.onClick.AddListener(OnBackBtnClicked);
    }

    public void SetUI(Player player)
    {
        _attackText.text = player.Attack.ToString();
        _defenseText.text = player.Defense.ToString();
        _healthText.text = player.Health.ToString();
        _criticalText.text = player.Critical.ToString();
    }

    public void OnBackBtnClicked()
    {
        Debug.Log("뒤로가기 버튼");
        // 스탯 창 끄기
        gameObject.SetActive(false);

        // 메인 UI 키기
        UIManager.Instance.SetActive("Main");

        Debug.Log("뒤로가기 버튼 클릭");
    }
}
