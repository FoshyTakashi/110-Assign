using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float         m_speed = -5f;
    public GameObject    m_otherBackground;

    //Background Chances
    public int           m_bg1Percent = 50;
    public int           m_bg2Percent = 25;
    public int           m_bg3Percent = 15;
    public int           m_bg4Percent = 10;

    void Update()
    {
        transform.position += new Vector3(m_speed * Time.deltaTime, 0f, 0f);

    }

    void LateUpdate()
    {
        if(transform.position.x <= -22)
        {
            ChangeBackgroundArt();

            float otherHalfWidth = m_otherBackground.GetComponent<SpriteRenderer>().bounds.extents.x;
            float myHalfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

            float xPos = m_otherBackground.transform.position.x + otherHalfWidth + myHalfWidth;
            xPos -= 0.25f;

            transform.position = new Vector3(xPos, m_otherBackground.transform.position.y, 0f);

        }
	}

    void ChangeBackgroundArt()
    {
        int randomNumber = Random.Range(0, 99);
        
        if (randomNumber < m_bg1Percent)
            {
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile1");
            }

        else if (randomNumber < m_bg1Percent + m_bg2Percent)
            {
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile2");
            }

        else if (randomNumber < m_bg1Percent + m_bg2Percent + m_bg3Percent)
            {
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile3");
            }
        else
            {
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile4");
            }

      }
}
