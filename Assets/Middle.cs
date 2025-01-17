using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    public Logic logic;
    public AudioSource pointSound;
    private bool scored = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (scored)
            {
                return;
            }
            pointSound.Play();
            logic.addScore(1);
            scored = true;
        }
    }
}
