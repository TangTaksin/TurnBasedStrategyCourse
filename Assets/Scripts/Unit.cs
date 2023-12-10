using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Vector3 targetPosition;
    private float stoppingDistance = 0.1f;
    private void Update()
    {
        float dir = Vector3.Distance(transform.position, targetPosition);
        if (dir > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Move(new Vector3(4, 0, 4));
        }
    }
    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}
