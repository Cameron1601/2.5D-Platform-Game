using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttacks : MonoBehaviour
{
    public GameObject fireBall;
    public Transform fireBallPoint;
    public float fireBallSpeed = 600;
    public void fireBallAttack()
    {
        GameObject ball = Instantiate(fireBall, fireBallPoint.position, Quaternion.identity);
        ball.GetComponent<Rigidbody>().AddForce(fireBallPoint.forward * fireBallSpeed);
    }
}
