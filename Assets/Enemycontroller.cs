using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    float speed = 3f;

    int health = 1;

    [SerializeField]
    GameObject explosionPrefab;

    void Start()
    {
        float x = Random.Range(-12f, 12f);
        Vector2 position = new Vector2(x, 7);
        transform.position = position;
    }


    void Update()
    {
        Vector2 movement = new Vector2(0, -speed) * Time.deltaTime;

        transform.Translate(movement);

        if (transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shot")
        {
            health--;
            if (health == 0)
            {
                Destroy(this.gameObject);
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }

        }

        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

    }


}
