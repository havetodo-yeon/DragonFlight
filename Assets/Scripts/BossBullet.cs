using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float speed = 3.0f;

    Vector2 vec;

    private void Start()
    {
        vec = new Vector2(Random.Range(-1.0f, 1.0f), -1.0f);
    }

    private void Update()
    {
        transform.Translate(vec * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            // 미사일 지움
            Destroy(gameObject);
            GameManager.Instance.GetHurt(collision.gameObject);
            GameObject go = Instantiate(player.Collision, transform.position, Quaternion.identity);
            GameManager.Instance.MinusScore(10);

        }
    }

}
