using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //���� ī�޶�
    private Camera m_Camera;

    //Ű���� �Է��� ���� ������Ʈ
    private PlayerInput _input;
    //�� ������Ʈ�� �ݶ��̴�
    private BoxCollider2D _collider;

    //������ �ݶ��̴��� ����� �迭
    private RaycastHit2D[] wallHitsX = new RaycastHit2D[5];
    private RaycastHit2D[] wallHitsY = new RaycastHit2D[5];

    //������ ������Ʈ�� ���̾�
    [SerializeField]
    private ContactFilter2D contactFilter;

    //��������
    private float detectionRange = 0.2f;

    //�� üũ
    private bool isWallX = false;
    private bool isWallY = false;

    //�÷��̾ �����̴� �ӵ�
    private float moveSpeed = 10f;

    private Animator animator;

    private void Start()
    {
        //������Ʈ ��������
        _input = GetComponent<PlayerInput>();
        _collider = GetComponent<BoxCollider2D>();
        m_Camera = Camera.main;
        animator = GetComponentInChildren<Animator>();

        //����Ƽ �̺�Ʈ ���
        CharSelectManager.OnCharChange += SetAnimator;
    }

    private void Update()
    {
        //ī�޶� �÷��̾�� ����
        m_Camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        Move();

        if (animator != null)
        {
            SetAnimation();
        }
    }

    private void Move()
    {
        //�̵� �Է��� �������� �۵����� ����
        if (_input.move == Vector2.zero)
        {
            return;
        }

        //���� �������� ó���� ����
        Vector2 realMove = _input.move;

        //�� Ȯ��
        isWallX = _collider.Cast(new Vector2(realMove.x, 0), contactFilter, wallHitsX, detectionRange) > 0;
        isWallY = _collider.Cast(new Vector2(0, realMove.y), contactFilter, wallHitsY, detectionRange) > 0;

        //X�� �̵��� ���� �ɸ����
        if (isWallX)
        {
            realMove.x = 0;
        }

        //Y�� �̵��� ���� �ɸ����
        if (isWallY)
        {
            realMove.y = 0;
        }

        //�̵� ó��
        transform.Translate(realMove * moveSpeed * Time.deltaTime);
    }

    private void SetAnimation()
    {
        Debug.Log("�ִϸ����� �۵���");
        animator.SetInteger("MoveX", (int)_input.move.x);
        animator.SetInteger("MoveY", (int)_input.move.y);
    }

    //�ִϸ����� ����, ĳ���� ����� ȣ��
    private void SetAnimator(Animator newAnimator)
    {
        //ĳ���� �������� �ִϸ����͸� �޾Ƽ� ���
        animator = newAnimator;
    }
}
