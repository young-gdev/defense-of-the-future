using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mina : MonoBehaviour
{
    public float damage = 100f;
    public int timeToUp = 3;
    public int timeToExplosion = 1;
    public bool up = false;

    private void Start()
    {
        StartCoroutine(MinaUp());
    }

    IEnumerator MinaUp()
    {
        yield return new WaitForSeconds(timeToUp);
        transform.Translate(Vector2.up * 0.2f);
        up = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && up == true)
        {
            Destroy(gameObject);
        }
    }
}
