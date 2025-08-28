using UnityEngine;

public class GameManager : SingletonMono<GameManager>
{
    [field:SerializeField] public Player Player { get; private set; }

    private void Awake()
    {
        Player = new Player();
    }

    // UI쪽에서 플레이어를 가져가서 UI를 세팅한다. 
    // UI 어디 쪽에서 가져가지? UIManager
}
