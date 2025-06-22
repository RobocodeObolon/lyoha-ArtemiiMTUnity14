using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 startingPosition;
    public Transform followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

    void Start()
    {
        startingPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (followTarget != null)
        {
            targetPos = new Vector3(followTarget.position.x, followTarget.position.y);
            Vector3 velocity = (targetPos - transform.position) * moveSpeed;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, 1f, Time.deltaTime);
        }
    }
}
