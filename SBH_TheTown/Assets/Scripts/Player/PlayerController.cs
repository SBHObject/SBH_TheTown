using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //키보드 입력을 받을 컴포넌트
    private PlayerInput _input;
    //오브젝트를 움직일 컴포넌트
    private CharacterController _controller;
    //이 오브젝트의 콜라이더
    private BoxCollider2D _collider;

    //감지된 콜라이더가 저장될 배열
    private RaycastHit2D[] wallHitsX = new RaycastHit2D[5];
    private RaycastHit2D[] wallHitsY = new RaycastHit2D[5];

    //감지될 오브젝트의 레이어
    [SerializeField]
    private ContactFilter2D contactFilter;

    //감지범위
    private float detectionRange = 0.2f;

    //벽 체크
    private bool isWallX = false;
    private bool isWallY = false;

    //플레이어가 움직이는 속도
    private float moveSpeed = 10f;

    private void Start()
    {
        //컴포넌트 가져오기
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<PlayerInput>();
        _collider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        //이동 입력이 없을때는 작동하지 않음
        if (_input.move == Vector2.zero)
        {
            return;
        }

        //실제 움직임을 처리할 변수
        Vector2 realMove = _input.move;

        //벽 확인
        isWallX = _collider.Cast(new Vector2(realMove.x, 0), contactFilter, wallHitsX, detectionRange) > 0;
        isWallY = _collider.Cast(new Vector2(0, realMove.y), contactFilter, wallHitsY, detectionRange) > 0;

        //X축 이동중 벽에 걸릴경우
        if (isWallX)
        {
            realMove.x = 0;
        }

        //Y축 이동중 벽에 걸릴경우
        if (isWallY)
        {
            realMove.y = 0;
        }

        //이동 처리
        transform.Translate(realMove * moveSpeed * Time.deltaTime);

    }
}
