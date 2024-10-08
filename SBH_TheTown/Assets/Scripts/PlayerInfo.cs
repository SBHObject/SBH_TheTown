using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어의 이름, 현재 캐릭터를 저장하는 클래스
public class PlayerInfo : MonoBehaviour
{
    //플레이어 이름 정보
    private string playerName = "";
    public string PlayerName
    {
        get { return playerName; }
        private set
        {
            if(value == "")
            {
                playerName = "방문자";
            }
            else
            {
                playerName = value;
            }
        }
    }

    //플레이어의 캐릭터 정보
    private GameObject playerChar;

    public GameObject PlayerChar
    {
        get { return playerChar; }
    }

    private void Start()
    {
        //다음씬으로 넘겨주기
        DontDestroyOnLoad(gameObject);
    }

    public void SetInfo(GameObject character, string name)
    {
        playerChar = character;
        PlayerName = name;
    }
}
