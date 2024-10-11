using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListUIManager : MonoBehaviour
{
    //NPC���� ���� �θ� ������Ʈ
    public GameObject npcPerent;
    //NPC ����Ʈ
    private List<NpcController> npcList = new List<NpcController>();

    //�÷��̾� ������
    public PlayerDataObject playerData;

    //NPC �� ����Ʈ UI ������
    public GameObject npcListContentPrefab;

    //�÷��̾��� ����Ʈ UI ������
    public GameObject playerListContentPrefab;

    //npc ����Ʈ�� ��ġ�� ������Ʈ
    public GameObject npcListUI;
    //�÷��̾� ����Ʈ�� ��ġ�� ������Ʈ
    public GameObject playerListUI;

    private void Start()
    {
        //���۰� ���ÿ� NPC �� ������ ����Ʈ�� ����
        foreach (Transform npc in npcPerent.transform)
        {
            npcList.Add(npc.GetComponent<NpcController>());

            //����Ʈ�� �����鼭 NPC ����Ʈ ����, ���� ����
            GameObject npcUI = Instantiate(npcListContentPrefab, npcListUI.transform);
            npcUI.GetComponent<NpcListUIInfo>().SetInfo(npc.GetComponent<NpcController>().npcData);
        }

        GameObject playerUI = Instantiate(playerListContentPrefab, playerListUI.transform);
        playerUI.GetComponent<PlayerListUIInfo>().SetPlayerData(playerData);
    }
}
