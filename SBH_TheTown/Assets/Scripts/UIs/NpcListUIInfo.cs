using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//NPC 리스트 UI에 표기될 정보를 처리하는 스크립트
public class NpcListUIInfo : MonoBehaviour
{
    public TextMeshProUGUI npcNameTextbox;

    public Image npcImage;

    //NPC 정보를 받아서 채워넣는 기능의 함수
    public void SetInfo(NpcDataObject npcData)
    {
        npcNameTextbox.text = npcData.npcName;
        npcImage.sprite = npcData.npcSprite;
    }
}
