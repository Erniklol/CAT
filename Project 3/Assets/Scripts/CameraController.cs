using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float rotateSpeed= 10.0f , speed =10.0f , zoomSpeed=100.0f;

    private float _mult=1f;

    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        float rotate= 0f;
        if(Input.GetKey(KeyCode.Q)){
            rotate=-1f;
        }else if(Input.GetKey(KeyCode.E)){
            rotate= 1f;
        }
        _mult = Input.GetKey(KeyCode.LeftShift) ? 2f : 1f;
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * rotate *_mult, Space.World);
        transform.Translate(new Vector3(hor,0, ver) * Time.deltaTime * _mult * speed, Space.Self);
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(transform.up * zoomSpeed * zoomInput * Time.deltaTime * _mult, Space.World);
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, -0.25f, 20f),
            transform.position.z
        );
    }


}
