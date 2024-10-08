using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPlayerInfo : MonoBehaviour
{
    //������ �����ϰ�, �Ѱ��� ��ũ��Ʈ
    private PlayerInfo playerInfo;

    //���õ� ĳ����
    private GameObject selectedChar;

    public TextMeshProUGUI nameInputField;

    private void Start()
    {
        playerInfo = FindObjectOfType<PlayerInfo>();
    }

    //������ �޾Ƽ�, playerInfo ��ũ��Ʈ�� �Ѱ���
    public void SetInfomations()
    {
        playerInfo.SetInfo(selectedChar, nameInputField.text);
    }

    //ĳ���� ������, �Ѱ��ֱ�
    public void CharacterSelect(GameObject select)
    {
        selectedChar = select;
    }

    public void OpenSelectUI()
    {

    }
}
