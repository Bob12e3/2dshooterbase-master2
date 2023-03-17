using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shipcontroller : MonoBehaviour
{

    [SerializeField]
    int health = 5;

    [SerializeField]
    Slider healthMeter;
    [SerializeField]

    float speed = 3f;

    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    Transform guntransform;

    float shootTimer = 0;
    float timeBetweenShots = 0.5f;

    void Start()
    {
        healthMeter.maxValue = health;
        healthMeter.value = health;
    }


    void Update()
    {

        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(xMove, yMove) * speed * Time.deltaTime;

        transform.Translate(movement);

        shootTimer += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && shootTimer > timeBetweenShots)
        {

            shootTimer = 0;
            Instantiate(bulletPrefab, guntransform.position, Quaternion.identity);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);
        if (other.gameObject.tag == "Enemy")
        {
            print("ouch");
            health--;
            healthMeter.value = health;
        }
    }
}
