using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : LoginUIManager
{
    //�÷��̾� ������Ʈ
    public GameObject player;
    //�÷��̾� ������ �����ϴ� ������Ʈ
    private PlayerCharacterManager playerCharManager;
    //�÷��̾� �̵� ����
    private PlayerInput playerInput;

    //�̸� �ٲٱ� UI
    public GameObject renameUI;
    
    //LoginUI���� ���� ĳ���� ��������Ʈ ���� ���� ����...
    //���� ��ũ��Ʈ ������� �α����ϰ� ���θ޴��� ���� ����ϴ°� ����������
    protected override void Start()
    {
        //�±׷� �÷��̾� ã��
        player = GameObject.FindWithTag("Player");
        playerCharManager = player.GetComponent<PlayerCharacterManager>();
        playerInput = player.GetComponent<PlayerInput>();

        selectedCharData = playerData.data;
    }

    //��������Ʈ ���� ���� ����
    public override void CharacterSelect(CharacterData character)
    {
        selectedCharData = character;
        playerData.PlayerDataChange(character);

        playerCharManager.SetPlayerChar();
    }

    //�̸� �ٲٱ� UI Ȱ��ȭ
    public void OpenRenameUI()
    {
        //UI �ѱ�, ����
        if(renameUI.activeSelf == true)
        {
            renameUI.SetActive(false);
            //�÷��̾� ���� ����
            playerInput.CanMove = true;
        }
        else
        {
            renameUI.SetActive(true);
            //�÷��̾� ���� �Ұ���
            playerInput.CanMove = false;
        }

        //ĳ���� ���� UI�� ���������� ����
        if(charSelectUI.activeSelf == true)
        {
            charSelectUI.SetActive(false);
        }
    }

    //ĳ���� ���� UI, ��� �ϳ� �߰�
    public override void OpenCharSelectUI()
    {
        //���������� ����, ���������� Ű��
        if (charSelectUI.activeSelf)
        {
            charSelectUI.SetActive(false);
            //�÷��̾� ���� ����
            playerInput.CanMove = true;
        }
        else
        {
            charSelectUI.SetActive(true);
            //�÷��̾� ���� �Ұ���
            playerInput.CanMove = false;
            //UI�� �Ӷ�, ���� ĳ���� ����
            ControlCharSelectUI();
        }

        //�̸����� UI�� ���������� ����
        if (renameUI.activeSelf == true)
        {
            renameUI.SetActive(false);
        }
    }

    //�̸��ٲٱ� �Ϸ�
    public void CloseRenameUI()
    {
        //�����ϰ�� �̸��� �ٲ��� ����
        if(playerNameInput.text != "")
        {
            playerData.PlayerNameChange(playerNameInput.text);
        }
        //�÷��̾� �̸� �ٲٱ� ��û
        playerCharManager.ChangePlayerName();

        //UI ����
        renameUI.SetActive(false);
        //�÷��̾� ���� ����
        playerInput.CanMove = true;
    }
}
