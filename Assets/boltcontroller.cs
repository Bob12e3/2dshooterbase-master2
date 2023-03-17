using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltcontroller : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        Vector2 movement = new Vector2(0, 0.04f);

        transform.Translate(movement);

        if (transform.position.y > 7)
        {
            Destroy(this.gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
