using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//NPC ����Ʈ UI�� ǥ��� ������ ó���ϴ� ��ũ��Ʈ
public class NpcListUIInfo : MonoBehaviour
{
    public TextMeshProUGUI npcNameTextbox;

    public Image npcImage;

    //NPC ������ �޾Ƽ� ä���ִ� ����� �Լ�
    public void SetInfo(NpcDataObject npcData)
    {
        npcNameTextbox.text = npcData.npcName;
        npcImage.sprite = npcData.npcSprite;
    }
}
