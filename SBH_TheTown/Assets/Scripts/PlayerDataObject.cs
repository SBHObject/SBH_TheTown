using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Character/PlayerData")]
public class PlayerDataObject : ScriptableObject
{
    //현재 캐릭터 데이터
    public CharacterData data;
    //선택된 캐릭터 프리팹
    public GameObject characterPrefab;
    //플레이어 이름
    public string playerName;

    public UnityAction OnInfoChanged;

    public PlayerDataObject(CharacterData _data)
    {
        data = _data;
        characterPrefab = data.characterPrefab;
    }

    //플레이어 캐릭터 변경시, 데이터 변경
    public void PlayerDataChange(CharacterData changeData)
    {
        data = changeData;
        characterPrefab = changeData.characterPrefab;

        //UI 변경을 위한 이벤트
        OnInfoChanged?.Invoke();
    }

    //플레이어 이름 변경시, 데이터 오브젝트 변경
    public void PlayerNameChange(string name)
    {
        playerName = name;

        //UI 변경을 위한 이벤트
        OnInfoChanged?.Invoke();
    }
}
