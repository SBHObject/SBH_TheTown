using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

//플레이어의 캐릭터, 이름을 관리하는 클래스
public class PlayerCharacterManager : MonoBehaviour
{
    //플레이어의 정보를 가진 스크립터블 오브젝트
    [SerializeField]
    private PlayerDataObject playerData;

    //플레이어의 캐릭터가 위치할 오브젝트
    public Transform playerCharPosition;

    //캐릭터 변경시 이벤트 발생
    public UnityAction<Animator> OnCharChange;

    //플레이어의 이름이 표기될 텍스트박스
    public TextMeshProUGUI nameText;
    

    //현재 캐릭터의 프리팹 저장
    private GameObject nowChar;

    private void Start()
    {
        //데이터로부터 선택한 캐릭터 가져오기
        SetPlayerChar();
        //데이터로부터 이름 가져오기
        nameText.text = playerData.playerName;
    }

    public void SetPlayerChar()
    {
        //기존 오브젝트가 있으면 삭제
        if (nowChar != null)
        {
            //기존 오브젝트 파괴
            Destroy(playerCharPosition.GetComponentInChildren<SpriteRenderer>().gameObject);
        }

        //선택한 캐릭터 오브젝트 생성
        nowChar = Instantiate(playerData.characterPrefab, playerCharPosition.transform);

        //생성한 캐릭터 오브젝트의 애니메이터 컴포넌트를 넘겨줌
        OnCharChange?.Invoke(nowChar.GetComponent<Animator>());
    }

    public void ChangePlayerName(string name)
    {
        playerData.PlayerNameChange(name);
        nameText.text = playerData.playerName;
    }
}
