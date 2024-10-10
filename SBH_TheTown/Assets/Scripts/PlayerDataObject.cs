using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Character/PlayerData")]
public class PlayerDataObject : ScriptableObject
{
    //현재 캐릭터 데이터
    public CharacterData data;
    //선택된 캐릭터 프리팹
    public GameObject characterPrefab;
    //플레이어 이름
    public string playerName;

    public PlayerDataObject(CharacterData _data)
    {
        data = _data;
        characterPrefab = data.characterPrefab;
    }

    public void PlayerDataChange(CharacterData changeData)
    {
        data = changeData;
        characterPrefab = changeData.characterPrefab;
    }
}
