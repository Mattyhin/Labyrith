using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 30;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D)) transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
    }
}
