using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

//�÷��̾��� ĳ����, �̸��� �����ϴ� Ŭ����
public class PlayerCharacterManager : MonoBehaviour
{
    //�÷��̾��� ������ ���� ��ũ���ͺ� ������Ʈ
    [SerializeField]
    private PlayerDataObject playerData;

    //�÷��̾��� ĳ���Ͱ� ��ġ�� ������Ʈ
    public Transform playerCharPosition;

    //ĳ���� ����� �̺�Ʈ �߻�
    public UnityAction<Animator> OnCharChange;

    //�÷��̾��� �̸��� ǥ��� �ؽ�Ʈ�ڽ�
    public TextMeshProUGUI nameText;
    

    //���� ĳ������ ������ ����
    private GameObject nowChar;

    private void Start()
    {
        //�����ͷκ��� ������ ĳ���� ��������
        SetPlayerChar();
        //�����ͷκ��� �̸� ��������
        nameText.text = playerData.playerName;
    }

    public void SetPlayerChar()
    {
        //���� ������Ʈ�� ������ ����
        if (nowChar != null)
        {
            //���� ������Ʈ �ı�
            Destroy(playerCharPosition.GetComponentInChildren<SpriteRenderer>().gameObject);
        }

        //������ ĳ���� ������Ʈ ����
        nowChar = Instantiate(playerData.characterPrefab, playerCharPosition.transform);

        //������ ĳ���� ������Ʈ�� �ִϸ����� ������Ʈ�� �Ѱ���
        OnCharChange?.Invoke(nowChar.GetComponent<Animator>());
    }

    public void ChangePlayerName(string name)
    {
        playerData.PlayerNameChange(name);
        nameText.text = playerData.playerName;
    }
}
