using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBehaviour : MonoBehaviour
{
    public GameObject Circle;
    public GameObject CircleFall;
    public static Color pink = new Vector4(0.93f, 0.5f, 0.85f, 1);
    public static Color violet = new Vector4(0.73f, 0.46f, 0.83f, 1);
    public static Color blue = new Vector4(0.5f, 0.46f, 0.83f, 1);
    public static Color[] colors = new Color[] { pink, violet, blue, violet };
    public static Color transparent = new Vector4(0, 0, 0, 0);
    public int f = 1, s = 0, count = 0;
    public float wait = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer fc = Circle.GetComponent<SpriteRenderer>();
        fc.color = colors[0];
        float x = Convert.ToSingle(wait);
        StartCoroutine(Move(x));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Move(float wait)
    {
        while (true)
        {
            if (count == 0)
            {
                yield return new WaitForSeconds(wait);
                count++;
            }
            if (f == 3)
                f = 0;
            if (s == 3)
                s = 0;
            GameObject newCircle = Instantiate(CircleFall, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z), Quaternion.identity);
            SpriteRenderer fc = Circle.GetComponent<SpriteRenderer>();
            fc.color = transparent;
            SpriteRenderer sc = newCircle.GetComponent<SpriteRenderer>();
            sc.color = colors[s];
            yield return new WaitForSeconds(0.5f);
            fc.color = colors[f];
            yield return new WaitForSeconds(1f);
            f++; s++;
        }
    }
}
