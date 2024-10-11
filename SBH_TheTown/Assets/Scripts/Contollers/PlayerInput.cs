using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//New Input System 으로부터 입력을 받아주는 클래스
public class PlayerInput : MonoBehaviour
{
    //인풋 시스템으로부터 값을 가져올 변수들
    public Vector2 move;
    public bool jump;

    public bool CanMove { get; set; } = true;

    //화살표 입력시 Vector2 값 매개변수로 받음
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    //스페이스바 입력시 bool 값 매개변수로 받음
    public void OnJump(InputValue value)
    {
        JumpInput(value.isPressed);
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
    public void JumpInput(bool jumpState)
    {
        if (CanMove)
        {
            jump = jumpState;
        }
    }
}
