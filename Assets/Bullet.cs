using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager score;
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            score.ScoreCalculator(10);
        }
    }
}
