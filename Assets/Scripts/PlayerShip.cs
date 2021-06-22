using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Quaternion quaternion;
    private float Speed;

    Rigidbody2D rb;
   [SerializeField]  private float CD = 0;
    Vector3 vector;

    void Start()
    {
        quaternion = transform.rotation;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CD -= Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Speed += 250 * Time.fixedDeltaTime;
            Quaternion rotation = Quaternion.AngleAxis(Speed, Vector3.forward);
            transform.rotation = quaternion * rotation;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Speed -= 250 * Time.fixedDeltaTime;
            Quaternion rotation = Quaternion.AngleAxis(Speed, Vector3.forward);
            transform.rotation = quaternion * rotation;
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.down * 2 * Time.fixedDeltaTime);
        }
      
       
    }

}

