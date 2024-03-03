using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class double_jump : MonoBehaviour
{

    public float jumpforce; 
    public int jump;
    public bool isjump;
    [SerializeField]Rigidbody2D Rigidbody2D;
    private void Awake()
    {
        jump = 0;
        isjump = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = Vector2.right;
        if (Input.GetMouseButtonDown(0)&& isjump)
        {
            jump++;
            if (jump < 3)
            {
                Rigidbody2D.AddForce(new Vector2(Rigidbody2D.velocity.x, jumpforce), ForceMode2D.Impulse);
            }
            else 
            {
                isjump = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isjump = true;
            jump = 0;
        }

        }
    }

