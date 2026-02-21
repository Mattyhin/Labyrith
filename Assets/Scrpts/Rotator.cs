using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 30;
    
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, -1 * speed * Time.deltaTime * Input.GetAxis("Horizontal")));
    }
}
