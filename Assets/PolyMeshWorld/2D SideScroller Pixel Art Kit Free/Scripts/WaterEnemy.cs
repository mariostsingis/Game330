using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("WATER");
    }
}
