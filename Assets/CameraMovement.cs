using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sens;
    float x_rotation;
    float y_rotation;
    public GameObject orientation;
    public GameObject player;
    public float shake = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        shake = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        shake = Mathf.Lerp(shake, 0f, 10f * Time.deltaTime);

        float _mouse_x = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sens;
        float _mouse_y = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sens;

        y_rotation += _mouse_x;

        x_rotation -= _mouse_y;
        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(x_rotation, y_rotation, 0f);
        orientation.transform.rotation = Quaternion.Euler(0f, y_rotation, 0f);

        transform.position = (player.transform.position - transform.forward * 5 + transform.up * 2) + new Vector3(Random.Range(-shake,shake), Random.Range(-shake, shake), Random.Range(-shake, shake));
    }
}
