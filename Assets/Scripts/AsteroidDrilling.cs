using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class AsteroidDrilling : MonoBehaviour
{
    public GameObject Spaceship;
    public GameObject PressSpace;
    int i = 0;
    public GameObject Asteroid;
    public TMP_Text TitanCount;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        float Distance = Vector2.Distance(this.transform.position, Spaceship.transform.position);
        if (Distance < 4f)
        {
            PressSpace.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                i++;
                this.transform.localScale = this.transform.localScale - new Vector3(0.198f, 0.198f);
                TitanCount.text = (Int32.Parse(TitanCount.text) + 1).ToString();
            }
            if (this.transform.localScale.y < 0.1f)
            {
                Asteroid.SetActive(false);
            }
        }
        else
        {
            PressSpace.SetActive(false);
        }
    }
}
