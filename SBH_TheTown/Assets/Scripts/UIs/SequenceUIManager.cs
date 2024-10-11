using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

//NPC와 상호작용시, 텍스트 박스 발생을 관리하는 스크립트
public class SequenceUIManager : MonoBehaviour
{
    #region singleton
    private static SequenceUIManager instance;

    public static SequenceUIManager Instance { get { return instance; } }

    public bool InstanceExist {  get { return instance != null; } }

    private void Awake()
    {
        if(InstanceExist)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
    }

    private void OnDestroy()
    {
        if(instance == this)
        {
            instance = null;
        }
    }
    #endregion

    //대화창
    public GameObject DialogUI;

    //상호작용 UI 구성
    public Image npcImage;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI sequenceText;

    //대화창이 활성화,비활성화 되면 이벤트 발생
    public UnityAction<bool> OnUIOpen;

    //NPC로부터 정보 받아오기
    public void InteracteNpc(NpcDataObject npcData)
    {
        npcImage.sprite = npcData.npcSprite;
        npcNameText.text = npcData.npcName;

        OnUIOpen?.Invoke(true);

        DialogUI.SetActive(true);
    }

    public void CloseDialogUI()
    {
        DialogUI.SetActive(false);

        OnUIOpen?.Invoke(false);
    }
}
