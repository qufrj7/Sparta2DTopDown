using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 무브먼트

    private TopDownController2D controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // 내 컴포넌트 안에서 끝나는 것을 한다.

        // controller랑 TopDownMovement가 같은 게임 오브젝트 안에 존재한다.
        controller = GetComponent<TopDownController2D>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // FixedUpdate는 물리 업데이트 관련
        // Rigidbody의 값을 바꿔야 하기에 FixedUpdate
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction) 
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction; 
    }
}

