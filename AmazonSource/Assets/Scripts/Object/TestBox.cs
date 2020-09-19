using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 0.2f);          //When the box touches the floor, it'll be destroyed after 0.2 "seconds".
        }

        if (collision.gameObject.tag == "Character")
        {
            //Deal damage to the Character. We can also have the damage script on the Character instead.
        }
    }
}
