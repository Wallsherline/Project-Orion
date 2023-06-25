using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grade : MonoBehaviour
{
    GameObject Grade1;
    GameObject Grade2;
    GameObject Grade3;
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
}
