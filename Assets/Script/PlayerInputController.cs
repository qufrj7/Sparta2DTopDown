using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController2D
{
    private Camera camera;
    private void Awake()
    {
        camera = Camera.main; // MainCamera 태그가 붙어있는 카메라를 가져온다.
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
        // 실제 움직이는 처리는 여기서 하는 것이 아니라 PlayerMovement에서 한다.
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldpos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldpos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}