using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListUIManager : MonoBehaviour
{
    //NPC들이 속한 부모 오브젝트
    public GameObject npcPerent;
    //NPC 리스트
    private List<NpcController> npcList = new List<NpcController>();

    //플레이어 데이터
    public PlayerDataObject playerData;

    //NPC 의 리스트 UI 프리팹
    public GameObject npcListContentPrefab;

    //플레이어의 리스트 UI 프리팹
    public GameObject playerListContentPrefab;

    //npc 리스트가 위치할 오브젝트
    public GameObject npcListUI;
    //플레이어 리스트가 위치할 오브젝트
    public GameObject playerListUI;

    private void Start()
    {
        //시작과 동시에 NPC 들 정보를 리스트에 넣음
        foreach (Transform npc in npcPerent.transform)
        {
            npcList.Add(npc.GetComponent<NpcController>());

            //리스트에 넣으면서 NPC 리스트 생성, 정보 수정
            GameObject npcUI = Instantiate(npcListContentPrefab, npcListUI.transform);
            npcUI.GetComponent<NpcListUIInfo>().SetInfo(npc.GetComponent<NpcController>().npcData);
        }

        GameObject playerUI = Instantiate(playerListContentPrefab, playerListUI.transform);
        playerUI.GetComponent<PlayerListUIInfo>().SetPlayerData(playerData);
    }
}
