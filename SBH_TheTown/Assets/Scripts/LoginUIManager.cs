using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginUIManager : MonoBehaviour
{
    //캐릭터 선택 UI 오브젝트
    public GameObject charSelectUI;
    //캐릭터 선택 버튼들
    public Button[] charButtons;
    //선택된 캐릭터 이미지 표기
    [SerializeField]
    private Image selectedCharImage;
    
    //플레이어 정보를 저장하는 스크립터블 오브젝트
    [SerializeField]
    private PlayerDataObject playerData;

    //캐릭터 정보 데이터베이스
    [SerializeField]
    private CharacterDatabase charDatabase;
    //현재 캐릭터 정보
    private CharacterData selectedCharData;

    public TextMeshProUGUI playerNameInput;

    private void Start()
    {
        selectedCharData = playerData.data;
        //캐릭터 이미지 표기
        selectedCharImage.sprite = selectedCharData.characterImage;
    }

    //캐릭터 선택 UI 켜기,끄기
    public void OpenCharSelectUI()
    {
        //켜져있으면 끄고, 꺼져있으면 키기
        if(charSelectUI.activeSelf)
        {
            charSelectUI.SetActive(false);
        }
        else
        {
            charSelectUI.SetActive(true);
            //UI를 켤때, 기존 캐릭터 선택
            ControlCharSelectUI();
        }
    }

    //캐릭터 선택창을 열 때, 기존 캐릭터가 선택된 상태로 유지
    public void ControlCharSelectUI()
    {
        for(int i = 0; i < charDatabase.charDatas.Count; i++)
        {
            if (charDatabase.charDatas[i] == selectedCharData)
            {
                charButtons[i].Select();
            }
        }
    }

    //캐릭터 선택 버튼, 정보를 동시에 넘겨주기
    public void CharacterSelect(CharacterData character)
    {
        selectedCharData = character;
        playerData.PlayerDataChange(character);
        selectedCharImage.sprite = character.characterImage;
    }

    //로그인 버튼 선택시 작동
    public void LogIn()
    {
        //플레이어의 이름 저장
        if (playerNameInput.text != "")
        {
            playerData.playerName = playerNameInput.text;
        }

        //메인씬으로 이동
        SceneManager.LoadScene("MainScene");
    }
}
