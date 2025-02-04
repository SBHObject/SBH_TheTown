using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcData", menuName = "Character/NPC")]
public class NpcDataObject : ScriptableObject
{
    //NPC 리스트와 대화에 사용할 스프라이트
    public Sprite npcSprite;
    //NPC 의 이름
    public string npcName;

    //NPC 대사
    [TextArea(15, 20)]
    public string npcDialog;
}
