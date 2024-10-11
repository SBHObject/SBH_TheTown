using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//New Input System ���κ��� �Է��� �޾��ִ� Ŭ����
public class PlayerInput : MonoBehaviour
{
    //��ǲ �ý������κ��� ���� ������ ������
    public Vector2 move;
    public bool jump;

    public bool CanMove { get; set; } = true;

    //ȭ��ǥ �Է½� Vector2 �� �Ű������� ����
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    //�����̽��� �Է½� bool �� �Ű������� ����
    public void OnJump(InputValue value)
    {
        JumpInput(value.isPressed);
    }

    //�Է¹��� ���� ������ ����
    public void MoveInput(Vector2 moveDirection)
    {
        if (CanMove)
        {
            move = moveDirection;
        }
    }

    //�Է¹��� ���� ������ ����
    public void JumpInput(bool jumpState)
    {
        if (CanMove)
        {
            jump = jumpState;
        }
    }
}
