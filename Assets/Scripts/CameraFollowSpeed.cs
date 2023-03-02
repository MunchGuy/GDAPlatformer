using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSpeed : MonoBehaviour
{
    public float followSpeed;
    public Transform player;
    public Vector3 offset;
    public bool isXLocked = false;
    public bool isYLocked = false;

    void Update()
    {
        float xTarget = player.position.x + offset.x;
        float yTarget = player.position.y + offset.y;

        float xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);

        transform.position = new Vector3(xNew, yNew, transform.position.z);

        float xlock = transform.position.x;
        if (!isXLocked)
        {
            xlock = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        }

        float ylock = transform.position.y;
        if (!isYLocked)
        {
            ylock = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
        }
    }
}
