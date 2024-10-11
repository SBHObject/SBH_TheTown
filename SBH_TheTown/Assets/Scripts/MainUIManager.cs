using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : LoginUIManager
{
    public PlayerCharacterManager playerCharManager;

    protected override void Start()
    {
        selectedCharData = playerData.data;
    }

    public override void CharacterSelect(CharacterData character)
    {
        selectedCharData = character;
        playerData.PlayerDataChange(character);

        playerCharManager.SetPlayerChar();
    }
}
