using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//����Ʈ�� �÷��̾� ������ ǥ���ϴ� ��ũ��Ʈ
public class PlayerListUIInfo : MonoBehaviour
{
    private PlayerDataObject playerData;

    public TextMeshProUGUI playerNameTextbox;

    public Image playerImage;

    //����Ʈ UI �� ǥ��� �÷��̾��� ������
    public void SetInfo()
    {
        playerNameTextbox.text = playerData.playerName;
        playerImage.sprite = playerData.data.characterImage;
    }

    public void SetPlayerData(PlayerDataObject _playerData)
    {
        playerData = _playerData;
        SetInfo();
        playerData.OnInfoChanged += SetInfo;
    }
}
