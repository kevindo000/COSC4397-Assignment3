using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landed : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Net")
        {
            Score.AddScore();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "OutofBound")
        {
            Destroy(gameObject);
        }
        else
        {

        }
    }
}
