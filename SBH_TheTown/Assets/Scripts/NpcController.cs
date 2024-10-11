using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Npc ��ũ��Ʈ, ��ȣ�ۿ� ����
public class NpcController : MonoBehaviour, IInteractive
{
    //��ȣ�ۿ� ���� ���� Ʈ����
    private BoxCollider2D m_Collider;

    //��ȣ�ۿ� ���ɽ�, �̸� �˷��ִ� �ؽ�Ʈ ������Ʈ
    public GameObject interactionInfo;

    //NPC ����
    public NpcDataObject npcData;

    public TextMeshProUGUI npcNameTextbox;

    //��ȭâ�� �ٷ�� ��ũ��Ʈ
    private SequenceUIManager dialogManager;

    private void Start()
    {
        //Ʈ���� ��������
        m_Collider = GetComponent<BoxCollider2D>();
        npcNameTextbox.text = npcData.npcName;

        //�̱��� ��������
        dialogManager = SequenceUIManager.Instance;
    }

    //���� ���� ������ ��ȣ�ۿ� ����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(true);
            //��ȣ�ۿ� ����
            collision.GetComponent<PlayerController>().CanInteracte = true;
            collision.GetComponent<PlayerController>().GetInteracteObject(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(false);
            //��ȣ�ۿ� �Ұ���
            collision.GetComponent<PlayerController>().CanInteracte = false;
        }
    }

    //��ȣ�ۿ�� �۵��� �Լ� -> UI Ȱ��ȭ
    public void InteracteAction()
    {
        if (dialogManager.DialogUI.activeSelf == false)
        {
            dialogManager.InteracteNpc(npcData);
        }
        else
        {
            dialogManager.CloseDialogUI();
        }
    }
}
