using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Id { get; private set; }
    public string Job {  get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public string Description { get; private set; }
    public List<ItemData> Inventory { get; set; }
    public Dictionary<ItemData, bool> ItemDictionary { get; private set; } // ������, ���뿩�� 
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }

    // ������ ������ 

    private void Awake()
    {
        Id = "�ڵ��뿹";
        Job = "Warrior";
        Gold = 10000;
        Level = 1;
        Experience = 2;
        Description = "�ڵ��� �뿹 �ڵ��� �뿹 �ڵ��� �뿹 �ڵ��� �뿹 �ڵ��� �뿹";

        ItemDictionary = new();

        Attack = 10;
        Defense = 5;
        Health = 100;
        Critical = 15;
    }

    private void Start()
    {
        Inventory = GameManager.Instance.itemList;

        for(int i = 0; i < Inventory.Count; i++)
        {
            ItemDictionary[Inventory[i]] = false;
        }

        ItemDictionary[Inventory[0]] = true; // test
    }
}
