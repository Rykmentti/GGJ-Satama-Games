using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelistaProjectile : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] float speed;
    float selfDestroyDelay;
    // Start is called before the first frame update
    void Start()
    {
        selfDestroyDelay = 5;
        Invoke("DestroySelf", selfDestroyDelay);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, 1f) * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyController>().ReceiveDamage(damage);
            DestroySelf();
        }
    }
    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
