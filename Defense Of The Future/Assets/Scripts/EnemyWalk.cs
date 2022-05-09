using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float speedWalk = 2f;

    private void Update()
    {
        transform.Translate(Vector2.left * speedWalk * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DeadZone")
        {
            Destroy(gameObject);
        }
    }
}
