using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightMovement : MonoBehaviour
{
    public float yMin = 4;
    public float yMax = -4;
    public float speed = 1f;
    public GameObject Bullet;
    public GameObject SpawnBullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        if (transform.position.y <= yMin & transform.position.y >= yMax)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * vertical);
            if (transform.position.y < yMax)
            {
                transform.position = new Vector2(transform.position.x, yMax);
            }
            if (transform.position.y > yMin)
            {
                transform.position = new Vector2(transform.position.x, yMin);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, SpawnBullets.transform, true);

        }
    }
}
