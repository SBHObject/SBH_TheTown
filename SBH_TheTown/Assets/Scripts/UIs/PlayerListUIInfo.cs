using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//리스트에 플레이어 정보를 표기하는 스크립트
public class PlayerListUIInfo : MonoBehaviour
{
    //리스트에서 사용할 플레이어 정보
    private PlayerDataObject playerData;

    //플레이어 이름 텍스트박스
    public TextMeshProUGUI playerNameTextbox;
    //리스트에 뜰 이미지
    public Image playerImage;

    //리스트 UI 에 표기될 플레이어의 데이터 수정
    public void SetInfo()
    {
        playerNameTextbox.text = playerData.playerName;
        playerImage.sprite = playerData.data.characterImage;
    }

    //플레이어 데이터 받아오기
    public void GetPlayerData(PlayerDataObject _playerData)
    {
        playerData = _playerData;
        SetInfo();
        playerData.OnInfoChanged += SetInfo;
    }
}
