using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class MoveToMouse : MonoBehaviour
{
    // Корабль двигается за мышкой
    public float speed = 1f;
    private float speedV;
    public GameObject spaceship;
    // То, к чему корабль будет стремиться (наша мышка)
    private Vector3 target;
    private float mouseDistance = 0;

    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // БЛОК ДВИЖЕНИЯ
        mouseDistance = Vector2.Distance(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        speedV = speed * mouseDistance;
        if (speedV > speed * 10) { speedV = speed * 10; }
        Debug.Log("speedV " + speedV);
        Debug.Log("speed  " + speed);
        if (true)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speedV * Time.deltaTime);

        // БЛОК ПОВОРОТА
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
    }
}
