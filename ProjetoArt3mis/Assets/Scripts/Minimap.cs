using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;
    private Camera camera;

    private void Start()
    {
        camera = transform.GetComponent<Camera>();
        Matrix4x4 mat = camera.projectionMatrix;
        mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
        camera.projectionMatrix = mat;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
