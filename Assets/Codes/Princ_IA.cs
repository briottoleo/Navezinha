using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Princ_IA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        attack();
    }
    private void OnTriggerExit(Collider other)
    {
        patrol();
    }

    private void patrol()
    {
        gameObject.GetComponent<IA_Patrulha>().enabled = true;
        gameObject.GetComponent<IA_Ship>().enabled = false;
    }
    private void attack()
    {
        gameObject.GetComponent<IA_Patrulha>().enabled = false;
        gameObject.GetComponent<IA_Ship>().enabled = true;
    }
}