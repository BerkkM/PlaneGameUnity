using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMoveScript : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.y > 1)
            {
                //Move up
                rb.transform.Translate(0, moveSpeed, 0);

            }
            else if (mousePos.y < -1)
            {
                //move down
                rb.transform.Translate(0, -moveSpeed, 0);
            }
        }
    }
}