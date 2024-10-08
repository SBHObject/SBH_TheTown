using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPlayerInfo : MonoBehaviour
{
    //정보를 저장하고, 넘겨줄 스크립트
    private PlayerInfo playerInfo;

    //선택된 캐릭터
    private GameObject selectedChar;

    public TextMeshProUGUI nameInputField;

    private void Start()
    {
        playerInfo = FindObjectOfType<PlayerInfo>();
    }

    //정보를 받아서, playerInfo 스크립트에 넘겨줌
    public void SetInfomations()
    {
        playerInfo.SetInfo(selectedChar, nameInputField.text);
    }

    //캐릭터 선택후, 넘겨주기
    public void CharacterSelect(GameObject select)
    {
        selectedChar = select;
    }

    public void OpenSelectUI()
    {

    }
}
