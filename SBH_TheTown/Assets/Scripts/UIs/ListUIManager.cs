using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListUIManager : MonoBehaviour
{
    //NPC들이 속한 부모 오브젝트
    public GameObject npcPerent;
    //NPC 리스트
    private List<GameObject> npcList = new List<GameObject>();
    public GameObject npcListUI;


    //플레이어 리스트
    private List<PlayerDataObject> playerList;

    //NPC 의 리스트 UI 프리팹
    public GameObject npcListContentPrefab;

    //플레이어의 리스트 UI 프리팹
    public GameObject playerListContentPrefab;

    private void Start()
    {
        
    }
}
