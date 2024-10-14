using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//New Input System ���κ��� �Է��� �޾��ִ� Ŭ����
public class PlayerInput : MonoBehaviour
{
    //��ǲ �ý������κ��� ���� ������ ������
    public Vector2 move;
    public bool interacte = false;

    //��ȣ�ۿ� ���� - 1ȸ�� �۵��ϰ� �����
    private bool tempInteracte = false;

    public bool CanMove { get; set; } = true;

    private void Start()
    {
        //�̺�Ʈ �Լ����(�̵� �Ұ���)
        SequenceUIManager.Instance.OnUIOpen += DialogOpenMoveControll; 
    }

    private void Update()
    {
        //�����̽��ٸ� ������ 1ȸ�� true�� �Ѱ��ִ� ��Ŀ����
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

    //ȭ��ǥ �Է½� Vector2 �� �Ű������� ����
    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    //�����̽��� �Է½� bool �� �Ű������� ����
    public void OnInteracte(InputValue value)
    {
        InteracteInput(value.isPressed);
        Debug.Log(value.isPressed);
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
    public void InteracteInput(bool interacteState)
    {
        tempInteracte = interacteState;
    }

    //��ȭ UI�� ���� �̵� Ȱ��ȭ, ��Ȱ��ȭ
    private void DialogOpenMoveControll(bool isUiOpen)
    {
        CanMove = !isUiOpen;

        //������ ����
        if(isUiOpen)
        {
            move = new Vector2(0, 0);
        }
    }
}
