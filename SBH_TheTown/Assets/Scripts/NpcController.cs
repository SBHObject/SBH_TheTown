using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Npc 스크립트, 상호작용 관리
public class NpcController : MonoBehaviour
{
    //상호작용 가능 범위 트리거
    private BoxCollider2D m_Collider;

    //상호작용 가능시, 이를 알려주는 텍스트 오브젝트
    public GameObject interactionInfo;

    //상호작용 가능 여부
    private bool canInteractive = false;

    private void Start()
    {
        //트리거 가져오기
        m_Collider = GetComponent<BoxCollider2D>();
    }

    //범위 내에 들어오면 상호작용 가능
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
