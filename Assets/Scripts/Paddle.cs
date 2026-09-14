using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float PaddleSpeed = 8f;
    public float minX;
    public float maxX;
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(touchPosition);
            transform.position = new Vector3(worldPosition.x, transform.position.y, transform.position.z);
        }

        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
    }

}