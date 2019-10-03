using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XicoRotate : MonoBehaviour
{
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        StartCoroutine(rotate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator rotate()
    {
        int i = 0;
        while (true)
        {
            i += 1;
            rb2D.MoveRotation((float)i);
            yield return new WaitForSeconds(.01f);

        }
    }
}
