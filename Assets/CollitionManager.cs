using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollitionManager : MonoBehaviour
{

    private Animator animator;
    public string isOn = "isOn";
    
    void Start()
    {
        // Encuentra automáticamente el Animator en el mismo GameObject
        animator = GetComponent<Animator>();

        // Verifica si el Animator existe
        if (animator == null)
        {
            Debug.LogError("No se encontró el Animator en " + gameObject.name);
        }
    }        void OnTriggerEnter2D(Collider2D coll)
        {
            Debug.Log("Chocaron¡¡");

            animator.SetBool(isOn, true);
        }

        void OnTriggerExit2D(Collider2D coll){
             animator.SetBool(isOn, false);
        }
}
