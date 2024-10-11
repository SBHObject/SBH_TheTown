using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//Npc ��ũ��Ʈ, ��ȣ�ۿ� ����
public class NpcController : MonoBehaviour
{
    //��ȣ�ۿ� ���� ���� Ʈ����
    private BoxCollider2D m_Collider;

    //��ȣ�ۿ� ���ɽ�, �̸� �˷��ִ� �ؽ�Ʈ ������Ʈ
    public GameObject interactionInfo;

    //NPC ����
    public NpcDataObject npcData;

    public TextMeshProUGUI npcNameTextbox;

    private void Start()
    {
        //Ʈ���� ��������
        m_Collider = GetComponent<BoxCollider2D>();
        npcNameTextbox.text = npcData.npcName;
    }

    //���� ���� ������ ��ȣ�ۿ� ����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(true);
            //��ȣ�ۿ� ����
            collision.GetComponent<PlayerController>().CanInteracte = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(false);
            //��ȣ�ۿ� �Ұ���
            collision.GetComponent<PlayerController>().CanInteracte = true;
        }
    }
}
