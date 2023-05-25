using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavePai : MonoBehaviour
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log("O player tomou" + damage + " de Damage");
    }
        
}
