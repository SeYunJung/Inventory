using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMono<GameManager>
{
    [field:SerializeField] public Player Player { get; private set; }

    public List<ItemData> itemList = new();
    //public Dictionary<ItemData, bool> itemDictionary = new();

    private void Awake()
    {
        //Player = new Player();
        Player = new GameObject("Player").AddComponent<Player>();
    }

    // �갡 ������ �����͸� 

    // UI�ʿ��� �÷��̾ �������� UI�� �����Ѵ�. 
    // UI ��� �ʿ��� ��������? UIManager
}
