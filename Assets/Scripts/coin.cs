using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotationspeed = 50;

    void Update()
    {
        transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerManager.numberOfCoins ++;
            Destroy(gameObject);
        }
    }
}
