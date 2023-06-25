using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject starhsip;
    public float speed;
    public float distance;
    public GameObject Expalvnjgos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, starhsip.transform.position);
        Vector2 direction = starhsip.transform.position - transform.position;

        if (Vector2.Distance(transform.position, starhsip.transform.position) < 8f)
        {
            Expalvnjgos.SetActive(true);
            transform.position = Vector2.MoveTowards(this.transform.position, starhsip.transform.position, speed * Time.deltaTime);
            var dir = transform.position - starhsip.transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            Expalvnjgos.SetActive(false);
        }
        
        


        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            SceneManager.LoadScene(2);
        }
    }
}
