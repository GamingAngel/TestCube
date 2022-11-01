using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 direction;

    public float moveSpeed;
    public float deathRange;

    private void FixedUpdate()
    {
        MoveObject();
        
    }

    private void MoveObject()
    {
        transform.Translate(moveSpeed * Time.deltaTime * direction);
        CheckDeathRange();
    }

    private void CheckDeathRange()
    {
        if (transform.position.z >= deathRange)
        {
            Destroy(gameObject);
        }
    }


}
