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

    // 얘가 아이템 데이터를 

    // UI쪽에서 플레이어를 가져가서 UI를 세팅한다. 
    // UI 어디 쪽에서 가져가지? UIManager
}
