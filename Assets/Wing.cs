using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public SpriteRenderer spriteRenderer;
    public Sprite wingDown;
    public Sprite wingUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myRigidbody.velocity.y <= 0) {
            spriteRenderer.sprite = wingDown;
        } else
        {
            spriteRenderer.sprite = wingUp;
        }
    }
}
