using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float speedWalk = 2f;
    public float hp = 100f;
    public float timeToExplosion = 1f;

    private void Update()
    {
        transform.Translate(Vector2.left * speedWalk * Time.deltaTime);

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DeadZone")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "mine")
        {
            hp -= 100;
            Destroy(other.gameObject);
        }
    }
}
