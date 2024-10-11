using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Character/PlayerData")]
public class PlayerDataObject : ScriptableObject
{
    //���� ĳ���� ������
    public CharacterData data;
    //���õ� ĳ���� ������
    public GameObject characterPrefab;
    //�÷��̾� �̸�
    public string playerName;

    public UnityAction OnInfoChanged;

    public PlayerDataObject(CharacterData _data)
    {
        data = _data;
        characterPrefab = data.characterPrefab;
    }

    public void PlayerDataChange(CharacterData changeData)
    {
        data = changeData;
        characterPrefab = changeData.characterPrefab;

        OnInfoChanged?.Invoke();
    }

    public void PlayerNameChange(string name)
    {
        playerName = name;
        OnInfoChanged?.Invoke();
    }
}
