using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMono<UIManager>
{
    [SerializeField] private UIMainMenu _uiMainMenu;
    [SerializeField] private Button _statusBtn;
    [SerializeField] private Button _inventoryBtn;

    [SerializeField] private UIStatus _uiStatus;
    [SerializeField] private UIInventory _uiInventory;

    private Player _player;

    private void Start()
    {
        _player = GameManager.Instance.Player;

        _uiMainMenu.SetUI(_player);
        _uiStatus.SetUI(_player);
    }

    public void SetInActive(string btnName)
    {
        switch (btnName)
        {
            // 상태 버튼 누른 경우 
            case Constants.SceneName.Status:
            case Constants.SceneName.Inventory:
                // 상태버튼, 인벤토리 버튼 비활성화 
                _statusBtn.gameObject.SetActive(false);
                _inventoryBtn.gameObject.SetActive(false);
                break;
        }
    }

    public void SetActive(string name)
    {
        switch (name)
        {
            case Constants.SceneName.Main:
                _statusBtn.gameObject.SetActive(true);
                _inventoryBtn.gameObject.SetActive(true);
                break;
        }
    }

    public void SetActiveUI(string uiName)
    {
        switch (uiName)
        {
            case Constants.SceneName.Status:
                _uiStatus.gameObject.SetActive(true);
                break;
            case Constants.SceneName.Inventory:
                _uiInventory.gameObject.SetActive(true);
                break;
        }
    }
}
