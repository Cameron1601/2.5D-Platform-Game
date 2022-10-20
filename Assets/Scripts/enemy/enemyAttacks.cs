using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttacks : MonoBehaviour
{
    public void Attack(int damageAmount)
    {
        PlayerManager.currentHealth -= damageAmount;
    }
}
