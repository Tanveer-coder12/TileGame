using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float PaddleSpeed = 8f;
    public float minX;
    public float maxX;

    void Update()
    {
        // Mobile touch control
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            MovePaddle(touch.position);
        }

        // PC mouse control
        else if (Input.GetMouseButton(0))
        {
            MovePaddle(Input.mousePosition);
        }

        // Keep paddle inside boundaries
        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, minX, maxX);

        transform.position = position;
    }

    void MovePaddle(Vector2 screenPosition)
    {
        Vector3 worldPosition =
            Camera.main.ScreenToWorldPoint(screenPosition);

        Vector3 position = transform.position;

        position.x = worldPosition.x;

        transform.position = position;
    }


}