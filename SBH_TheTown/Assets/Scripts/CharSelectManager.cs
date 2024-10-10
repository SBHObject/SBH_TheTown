using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharSelectManager : MonoBehaviour
{
    //�÷��̾��� ĳ���� �̹����� ��ġ�� ������Ʈ
    public GameObject playerCharPos;


    //ĳ���� ����� �̺�Ʈ �߻�
    public static UnityAction<Animator> OnCharChange;

    public void SetPlayerChar(GameObject character)
    {

        //���� ������Ʈ �ı�
        Destroy(playerCharPos.GetComponentInChildren<SpriteRenderer>().gameObject);

        //������ ĳ���� ������Ʈ ����
        GameObject newChar = Instantiate(character, playerCharPos.transform);

        //������ ĳ���� ������Ʈ�� �ִϸ����� ������Ʈ�� �Ѱ���
        OnCharChange?.Invoke(newChar.GetComponent<Animator>());
    }
}
