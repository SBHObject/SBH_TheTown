using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcData", menuName = "Character/NPC")]
public class NpcDataObject : ScriptableObject
{
    //NPC ����Ʈ�� ��ȭ�� ����� ��������Ʈ
    public Sprite npcSprite;
    //NPC �� �̸�
    public string npcName;
    //NPC �� ����� ������
    public GameObject npcPrefab;
}
