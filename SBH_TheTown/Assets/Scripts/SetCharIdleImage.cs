using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ��, �������� ��������Ʈ�� �����ϴ� ��ũ��Ʈ
public class SetCharIdleImage : MonoBehaviour
{
    //�ڽ��� ��������Ʈ ������
    private SpriteRenderer spriteRenderer;

    //�ڽ��� �ִϸ�����
    private Animator animator;

    //�ִϸ������� �Ķ����
    private int moveX;
    private int moveY;

    //��������Ʈ��
    public Sprite front;
    public Sprite back;
    public Sprite left;
    public Sprite right;

    //������ ������ ��������Ʈ
    private Sprite idleSprite;

    void Start()
    {
        //������Ʈ ��������
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        idleSprite = front;
    }

    void Update()
    {
        moveX = animator.GetInteger("MoveX");
        moveY = animator.GetInteger("MoveY");

        SetSprite();
    }

    private void SetSprite()
    {
        if (moveY == 0 && moveX != 0)
        {
            if (moveX > 0)
            {
                idleSprite = right;
            }
            else
            {
                idleSprite = left;
            }
        }

        if(moveX == 0 && moveY != 0)
        {
            if (moveY > 0)
            {
                idleSprite = front;
            }
            else
            {
                idleSprite = back;
            }
        }
    }

    public void ChangeSprite()
    {
        spriteRenderer.sprite = idleSprite;
    }
}
