using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Station : MonoBehaviour
{
    public GameObject Spaceship;
    public GameObject Shop;
    public TMP_Text Score;
    public GameObject Grade1;
    public GameObject Grade2;
    public GameObject Grade3;
    // Start is called before the first frame update

    public void setGrade(int Grade)
    {
        if (Grade == 1)
        {
            Grade1.SetActive(true);
        }
        if (Grade == 2)
        {
            Grade2.SetActive(true);
            Grade1.SetActive(false);
        }
        if (Grade == 3)
        {
            Grade3.SetActive(true);
            Grade1.SetActive(false);
            Grade2.SetActive(false);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector2.Distance(this.transform.position, Spaceship.transform.position);
        if (Distance < 10f)
        {
            Shop.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space) & Int32.Parse(Score.text) >= 5)
            {
                setGrade(2);
                Score.text = (Int32.Parse(Score.text) - 5).ToString();
            }
            
        }
        else
        {
            Shop.SetActive(false);
        }
    }
}
