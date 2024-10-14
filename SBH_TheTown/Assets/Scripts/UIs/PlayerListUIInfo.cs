using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//����Ʈ�� �÷��̾� ������ ǥ���ϴ� ��ũ��Ʈ
public class PlayerListUIInfo : MonoBehaviour
{
    //����Ʈ���� ����� �÷��̾� ����
    private PlayerDataObject playerData;

    //�÷��̾� �̸� �ؽ�Ʈ�ڽ�
    public TextMeshProUGUI playerNameTextbox;
    //����Ʈ�� �� �̹���
    public Image playerImage;

    //����Ʈ UI �� ǥ��� �÷��̾��� ������ ����
    public void SetInfo()
    {
        playerNameTextbox.text = playerData.playerName;
        playerImage.sprite = playerData.data.characterImage;
    }

    //�÷��̾� ������ �޾ƿ���
    public void GetPlayerData(PlayerDataObject _playerData)
    {
        playerData = _playerData;
        SetInfo();
        playerData.OnInfoChanged += SetInfo;
    }
}
