using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//움직임 후, 대기상태의 스프라이트를 지정하는 스크립트
public class SetCharIdleImage : MonoBehaviour
{
    //자신의 스프라이트 랜더러
    private SpriteRenderer spriteRenderer;

    //자신의 애니메이터
    private Animator animator;

    //애니메이터의 파라미터
    private int moveX;
    private int moveY;

    //스프라이트들
    public Sprite front;
    public Sprite back;
    public Sprite left;
    public Sprite right;

    //정지후 적용할 스프라이트
    private Sprite idleSprite;

    void Start()
    {
        //컴포넌트 가져오기
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
