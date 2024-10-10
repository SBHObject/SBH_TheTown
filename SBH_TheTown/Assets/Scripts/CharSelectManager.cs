using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharSelectManager : MonoBehaviour
{
    //플레이어의 캐릭터 이미지가 위치할 오브젝트
    public GameObject playerCharPos;


    //캐릭터 변경시 이벤트 발생
    public static UnityAction<Animator> OnCharChange;

    public void SetPlayerChar(GameObject character)
    {

        //기존 오브젝트 파괴
        Destroy(playerCharPos.GetComponentInChildren<SpriteRenderer>().gameObject);

        //선택한 캐릭터 오브젝트 생성
        GameObject newChar = Instantiate(character, playerCharPos.transform);

        //생성한 캐릭터 오브젝트의 애니메이터 컴포넌트를 넘겨줌
        OnCharChange?.Invoke(newChar.GetComponent<Animator>());
    }
}
