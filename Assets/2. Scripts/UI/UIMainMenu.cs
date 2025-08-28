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
        // 상태버튼, 인벤토리 버튼 비활성화 
        UIManager.Instance.SetInActive("Status");

        // 상태 UI 활성화 
        UIManager.Instance.SetActiveUI("Status");
    }

    private void OnInventoryBtnClicked()
    {
        // 상태버튼, 인벤토리 버튼 비활성화 
        UIManager.Instance.SetInActive("Inventory");

        // 인벤토리 UI 활성화
        UIManager.Instance.SetActiveUI("Inventory");
    }
}
