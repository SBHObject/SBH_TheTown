using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Npc ��ũ��Ʈ, ��ȣ�ۿ� ����
public class NpcController : MonoBehaviour
{
    //��ȣ�ۿ� ���� ���� Ʈ����
    private BoxCollider2D m_Collider;

    //��ȣ�ۿ� ���ɽ�, �̸� �˷��ִ� �ؽ�Ʈ ������Ʈ
    public GameObject interactionInfo;

    //��ȣ�ۿ� ���� ����
    private bool canInteractive = false;

    private void Start()
    {
        //Ʈ���� ��������
        m_Collider = GetComponent<BoxCollider2D>();
    }

    //���� ���� ������ ��ȣ�ۿ� ����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(true);
            canInteractive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(false);
            canInteractive = false;
        }
    }
}
