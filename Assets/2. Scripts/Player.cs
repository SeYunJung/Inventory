using System.Collections.Generic;

public class Player 
{
    public string Id { get; private set; }
    public string Job {  get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public string Description { get; private set; }
    public List<int> Inventory { get; private set; }
    public int Attack {  get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }

    public Player()
    {
        Id = "�ڵ��뿹";
        Job = "Warrior";
        Gold = 10000;
        Level = 1;
        Experience = 2;
        Description = "�ڵ��� �뿹 �ڵ��� �뿹 �ڵ��� �뿹 �ڵ��� �뿹 �ڵ��� �뿹";
        Inventory = new List<int>() { 3, 0, 4, 1, 2 };

        /// inventory
        /// 0 : ��
        /// 1 : ����
        /// 2 : Ȱ
        /// 3 : ����
        /// 4 : ���� 

        Attack = 10;
        Defense = 5;
        Health = 100;
        Critical = 15;
    }
}
