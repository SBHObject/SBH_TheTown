using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

//NPC�� ��ȣ�ۿ��, �ؽ�Ʈ �ڽ� �߻��� �����ϴ� ��ũ��Ʈ
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

    //��ȭâ
    public GameObject DialogUI;

    //��ȣ�ۿ� UI ����
    public Image npcImage;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI sequenceText;

    //��ȭâ�� Ȱ��ȭ,��Ȱ��ȭ �Ǹ� �̺�Ʈ �߻�
    public UnityAction<bool> OnUIOpen;

    //NPC�κ��� ���� �޾ƿ���
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