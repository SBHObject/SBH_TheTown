using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListUIManager : MonoBehaviour
{
    //NPC���� ���� �θ� ������Ʈ
    public GameObject npcPerent;
    //NPC ����Ʈ
    private List<GameObject> npcList = new List<GameObject>();
    public GameObject npcListUI;


    //�÷��̾� ����Ʈ
    private List<PlayerDataObject> playerList;

    //NPC �� ����Ʈ UI ������
    public GameObject npcListContentPrefab;

    //�÷��̾��� ����Ʈ UI ������
    public GameObject playerListContentPrefab;

    private void Start()
    {
        
    }
}
