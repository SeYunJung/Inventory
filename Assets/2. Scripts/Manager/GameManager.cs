using UnityEngine;

public class GameManager : SingletonMono<GameManager>
{
    [field:SerializeField] public Player Player { get; private set; }

    private void Awake()
    {
        Player = new Player();
    }

    // UI�ʿ��� �÷��̾ �������� UI�� �����Ѵ�. 
    // UI ��� �ʿ��� ��������? UIManager
}
