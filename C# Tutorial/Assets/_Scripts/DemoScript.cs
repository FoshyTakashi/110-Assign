using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{

    bool isAlive = true;
    public int hitPoints = 10;

    public int currentLevel = 0;
    int invincibleLevel = 5;


    void Start()
    {
        transform.position = new Vector3(0f, 2f, 0f);
        transform.rotation = Quaternion.Euler(0f, 90f, 0f);

    }
    void Update()
    {
        if(!isAlive)
        {
            gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        if (currentLevel < invincibleLevel)
        {
            hitPoints--;
        }

        if (hitPoints <= 0)
        {
            isAlive = false;
        }
    }
}
