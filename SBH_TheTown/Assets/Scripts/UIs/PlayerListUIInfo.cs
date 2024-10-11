using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//리스트에 플레이어 정보를 표기하는 스크립트
public class PlayerListUIInfo : MonoBehaviour
{
    private PlayerDataObject playerData;

    public TextMeshProUGUI playerNameTextbox;

    public Image playerImage;

    //리스트 UI 에 표기될 플레이어의 데이터
    public void SetInfo()
    {
        playerNameTextbox.text = playerData.playerName;
        playerImage.sprite = playerData.data.characterImage;
    }

    public void SetPlayerData(PlayerDataObject _playerData)
    {
        playerData = _playerData;
        SetInfo();
        playerData.OnInfoChanged += SetInfo;
    }
}
