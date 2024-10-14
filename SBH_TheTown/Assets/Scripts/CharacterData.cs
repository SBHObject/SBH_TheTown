using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharData", menuName = "Character/CharacterData")]
public class CharacterData : ScriptableObject
{
    //ĳ���� ������ ����
    public GameObject characterPrefab;
    //ĳ���� ��������Ʈ ����
    public Sprite characterImage;
}
