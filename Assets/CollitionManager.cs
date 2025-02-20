using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollitionManager : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D coll)
        {
            Debug.Log("Chocaron¡¡");
        }
}
