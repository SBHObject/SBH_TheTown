using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharData", menuName = "Character/CharacterData")]
public class CharacterData : ScriptableObject
{
    //캐릭터 프리팹 정보
    public GameObject characterPrefab;
    //캐릭터 스프라이트 정보
    public Sprite characterImage;
}
