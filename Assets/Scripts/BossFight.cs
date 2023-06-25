using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossFight : MonoBehaviour
{
    public Slider slider;
    public float MaxHealth = 4;
    public GameObject Explosion;
    public GameObject Cat;
    bool Yeah = true;
    public GameObject Boss;
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }

    void Start()
    {
        SetMaxHealth(MaxHealth);
    }

    IEnumerator waiter_not_that_waiter_just_waiter(float time)
    {
        yield return new WaitForSeconds(time);
        //my code here after 3 seconds
    }
    IEnumerator EndOfFight()
    {
        Explosion.SetActive(true);
        yield return new WaitForSecondsRealtime(0.7f);
        Cat.SetActive(false);


        waiter_not_that_waiter_just_waiter(0.92f);

        waiter_not_that_waiter_just_waiter(1.22f);
        Boss.SetActive(false);
        Console.Out.WriteLine("Lol");
        waiter_not_that_waiter_just_waiter(10f);
        SceneManager.LoadScene(1);
    }



    // Update is called once per frame
    void Update()
    {
        if (slider.value < MaxHealth)
        {
            SetHealth(slider.value + 0.1f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.Mouse0)) {
            SetHealth(slider.value - 0.1f);
        }

        if (slider.value <= 0 & Yeah) {
            Yeah = false;
            StartCoroutine(EndOfFight());
            
        }
    }

    private void OnTriggerEnter2D()
    {
        SetHealth(slider.value - 1f);
    }
}

