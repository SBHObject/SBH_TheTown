using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//New Input System 으로부터 입력을 받아주는 클래스
public class PlayerInput : MonoBehaviour
{
    //인풋 시스템으로부터 값을 가져올 변수들
    public Vector2 move;
    public bool interacte = false;

    //상호작용 관련 - 1회만 작동하게 만들기
    private bool tempInteracte = false;

    public bool CanMove { get; set; } = true;

    private void Start()
    {
        //이벤트 함수등록(이동 불가능)
        SequenceUIManager.Instance.OnUIOpen += DialogOpenMoveControll; 
    }

    private void Update()
    {
        //스페이스바를 누르면 1회만 true를 넘겨주는 매커니즘
        if (tempInteracte == true && interacte != tempInteracte)
        {
            interacte = true;
        }
        else
        {
            interacte = false;
        }

        tempInteracte = false;
    }

    //화살표 입력시 Vector2 값 매개변수로 받음
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    //스페이스바 입력시 bool 값 매개변수로 받음
    public void OnInteracte(InputValue value)
    {
        InteracteInput(value.isPressed);
        Debug.Log(value.isPressed);
    }

    //입력받은 값을 변수로 전달
    public void MoveInput(Vector2 moveDirection)
    {
        if (CanMove)
        {
            move = moveDirection;
        }
    }

    //입력받은 값을 변수로 전달
    public void InteracteInput(bool interacteState)
    {
        tempInteracte = interacteState;
    }

    //대화 UI에 따른 이동 활성화, 비활성화
    private void DialogOpenMoveControll(bool isUiOpen)
    {
        CanMove = !isUiOpen;

        //움직임 정지
        if(isUiOpen)
        {
            move = new Vector2(0, 0);
        }
    }
}
