using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Text UI")]
    [SerializeField] private TMP_Text _goldText;
    [SerializeField] private TMP_Text _idText;
    [SerializeField] private TMP_Text _jobText;
    [SerializeField] private TMP_Text _levelText;
    [SerializeField] private TMP_Text _experienceText;
    [SerializeField] private TMP_Text _descriptionText;

    [Header("Button")]
    [SerializeField] private Button _statusBtn;
    [SerializeField] private Button _inventoryBtn;

    private void Start()
    {
        _statusBtn.onClick.AddListener(OnStatusBtnClicked);
        _inventoryBtn.onClick.AddListener(OnInventoryBtnClicked);
    }

    public void SetUI(Player player)
    {
        _goldText.text = player.Gold.ToString();
        _idText.text = player.Id.ToString();
        _jobText.text = player.Job.ToString();
        _levelText.text = $"Lv {player.Level.ToString()}";
        _experienceText.text = $"{player.Experience.ToString()} / 12";
        _descriptionText.text = player.Description.ToString();
    }

    private void OnStatusBtnClicked()
    {
        // ���¹�ư, �κ��丮 ��ư ��Ȱ��ȭ 
        UIManager.Instance.SetInActive("Status");

        // ���� UI Ȱ��ȭ 
        UIManager.Instance.SetActiveUI("Status");
    }

    private void OnInventoryBtnClicked()
    {
        // ���¹�ư, �κ��丮 ��ư ��Ȱ��ȭ 
        UIManager.Instance.SetInActive("Inventory");

        // �κ��丮 UI Ȱ��ȭ
        UIManager.Instance.SetActiveUI("Inventory");
    }
}
