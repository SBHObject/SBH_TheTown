using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : LoginUIManager
{
    //플레이어 오브젝트
    public GameObject player;
    //플레이어 정보를 관리하는 컴포넌트
    private PlayerCharacterManager playerCharManager;
    //플레이어 이동 관리
    private PlayerInput playerInput;

    //이름 바꾸기 UI
    public GameObject renameUI;
    
    //LoginUI에서 선택 캐릭터 스프라이트 관련 정보 빼기...
    //상위 스크립트 만든다음 로그인하고 메인메뉴로 각각 상속하는게 나았으려나
    protected override void Start()
    {
        //태그로 플레이어 찾기
        player = GameObject.FindWithTag("Player");
        playerCharManager = player.GetComponent<PlayerCharacterManager>();
        playerInput = player.GetComponent<PlayerInput>();

        selectedCharData = playerData.data;
    }

    //스프라이트 관련 정보 빼기
    public override void CharacterSelect(CharacterData character)
    {
        selectedCharData = character;
        playerData.PlayerDataChange(character);

        playerCharManager.SetPlayerChar();
    }

    //이름 바꾸기 UI 활성화
    public void OpenRenameUI()
    {
        //UI 켜기, 끄기
        if(renameUI.activeSelf == true)
        {
            renameUI.SetActive(false);
            //플레이어 조종 가능
            playerInput.CanMove = true;
        }
        else
        {
            renameUI.SetActive(true);
            //플레이어 조종 불가능
            playerInput.CanMove = false;
        }

        //캐릭터 선택 UI가 켜져있으면 끄기
        if(charSelectUI.activeSelf == true)
        {
            charSelectUI.SetActive(false);
        }
    }

    //캐릭터 선택 UI, 기능 하나 추가
    public override void OpenCharSelectUI()
    {
        //켜져있으면 끄고, 꺼져있으면 키기
        if (charSelectUI.activeSelf)
        {
            charSelectUI.SetActive(false);
            //플레이어 조종 가능
            playerInput.CanMove = true;
        }
        else
        {
            charSelectUI.SetActive(true);
            //플레이어 조종 불가능
            playerInput.CanMove = false;
            //UI를 켤때, 기존 캐릭터 선택
            ControlCharSelectUI();
        }

        //이름변경 UI가 켜져있으면 끄기
        if (renameUI.activeSelf == true)
        {
            renameUI.SetActive(false);
        }
    }

    //이름바꾸기 완료
    public void CloseRenameUI()
    {
        //공백일경우 이름을 바꾸지 않음
        if(playerNameInput.text != "")
        {
            playerData.PlayerNameChange(playerNameInput.text);
        }
        //플레이어 이름 바꾸기 요청
        playerCharManager.ChangePlayerName();

        //UI 끄기
        renameUI.SetActive(false);
        //플레이어 조종 가능
        playerInput.CanMove = true;
    }
}
