using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 30;

    private void Update()
    {
        float input = Input.GetAxis("Horizontal");
        
        if (Input.GetMouseButton(0))
        {
            input = (Input.mousePosition.x / Screen.width) * 2 - 1;
        }

        transform.Rotate(0, 0, -1 * speed * Time.deltaTime * input);
    }
}