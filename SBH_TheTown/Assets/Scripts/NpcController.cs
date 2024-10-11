using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Npc 스크립트, 상호작용 관리
public class NpcController : MonoBehaviour, IInteractive
{
    //상호작용 가능 범위 트리거
    private BoxCollider2D m_Collider;

    //상호작용 가능시, 이를 알려주는 텍스트 오브젝트
    public GameObject interactionInfo;

    //NPC 정보
    public NpcDataObject npcData;

    public TextMeshProUGUI npcNameTextbox;

    //대화창을 다루는 스크립트
    private SequenceUIManager dialogManager;

    private void Start()
    {
        //트리거 가져오기
        m_Collider = GetComponent<BoxCollider2D>();
        npcNameTextbox.text = npcData.npcName;

        //싱글톤 가져오기
        dialogManager = SequenceUIManager.Instance;
    }

    //범위 내에 들어오면 상호작용 가능
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(true);
            //상호작용 가능
            collision.GetComponent<PlayerController>().CanInteracte = true;
            collision.GetComponent<PlayerController>().GetInteracteObject(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionInfo.SetActive(false);
            //상호작용 불가능
            collision.GetComponent<PlayerController>().CanInteracte = false;
        }
    }

    //상호작용시 작동할 함수 -> UI 활성화
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
