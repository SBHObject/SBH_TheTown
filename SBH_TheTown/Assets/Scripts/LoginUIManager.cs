using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginUIManager : MonoBehaviour
{
    //ĳ���� ���� UI ������Ʈ
    public GameObject charSelectUI;
    //ĳ���� ���� ��ư��
    public Button[] charButtons;
    //���õ� ĳ���� �̹��� ǥ��
    [SerializeField]
    private Image selectedCharImage;
    
    //�÷��̾� ������ �����ϴ� ��ũ���ͺ� ������Ʈ
    [SerializeField]
    private PlayerDataObject playerData;

    //ĳ���� ���� �����ͺ��̽�
    [SerializeField]
    private CharacterDatabase charDatabase;
    //���� ĳ���� ����
    private CharacterData selectedCharData;

    public TextMeshProUGUI playerNameInput;

    private void Start()
    {
        selectedCharData = playerData.data;
        //ĳ���� �̹��� ǥ��
        selectedCharImage.sprite = selectedCharData.characterImage;
    }

    //ĳ���� ���� UI �ѱ�,����
    public void OpenCharSelectUI()
    {
        //���������� ����, ���������� Ű��
        if(charSelectUI.activeSelf)
        {
            charSelectUI.SetActive(false);
        }
        else
        {
            charSelectUI.SetActive(true);
            //UI�� �Ӷ�, ���� ĳ���� ����
            ControlCharSelectUI();
        }
    }

    //ĳ���� ����â�� �� ��, ���� ĳ���Ͱ� ���õ� ���·� ����
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

    //ĳ���� ���� ��ư, ������ ���ÿ� �Ѱ��ֱ�
    public void CharacterSelect(CharacterData character)
    {
        selectedCharData = character;
        playerData.PlayerDataChange(character);
        selectedCharImage.sprite = character.characterImage;
    }

    //�α��� ��ư ���ý� �۵�
    public void LogIn()
    {
        //�÷��̾��� �̸� ����
        if (playerNameInput.text != "")
        {
            playerData.playerName = playerNameInput.text;
        }

        //���ξ����� �̵�
        SceneManager.LoadScene("MainScene");
    }
}
