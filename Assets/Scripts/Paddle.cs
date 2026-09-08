using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float PaddleSpeed = 8f;
    public float minX;
    public float maxX;
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * PaddleSpeed * Time.deltaTime;
        transform.Translate(movement);

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