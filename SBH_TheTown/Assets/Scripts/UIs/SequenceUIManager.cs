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
    public TextMeshProUGUI dialogText;

    //��ȭâ�� Ȱ��ȭ,��Ȱ��ȭ �Ǹ� �̺�Ʈ �߻�
    public UnityAction<bool> OnUIOpen;

    //NPC�κ��� ���� �޾ƿ���
    public void InteracteNpc(NpcDataObject npcData)
    {
        //��ȭâ ����, �̸�, �̹���, ��� �����ϱ�
        npcImage.sprite = npcData.npcSprite;
        npcNameText.text = npcData.npcName;
        dialogText.text = npcData.npcDialog;

        //UI Ȱ��ȭ�� �۵� �̺�Ʈ - �̵� �Ұ���
        OnUIOpen?.Invoke(true);

        //UI Ȱ��ȭ
        DialogUI.SetActive(true);
    }

    public void CloseDialogUI()
    {
        //UI ��Ȱ��ȭ
        DialogUI.SetActive(false);

        //�̵� �����ϵ��� Ǯ���ֱ�
        OnUIOpen?.Invoke(false);
    }
}
