using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�÷��̾��� �̸�, ���� ĳ���͸� �����ϴ� Ŭ����
public class PlayerInfo : MonoBehaviour
{
    //�÷��̾� �̸� ����
    private string playerName = "";
    public string PlayerName
    {
        get { return playerName; }
        private set
        {
            if(value == "")
            {
                playerName = "�湮��";
            }
            else
            {
                playerName = value;
            }
        }
    }

    //�÷��̾��� ĳ���� ����
    private GameObject playerChar;

    public GameObject PlayerChar
    {
        get { return playerChar; }
    }

    private void Start()
    {
        //���������� �Ѱ��ֱ�
        DontDestroyOnLoad(gameObject);
    }

    public void SetInfo(GameObject character, string name)
    {
        playerChar = character;
        PlayerName = name;
    }
}
