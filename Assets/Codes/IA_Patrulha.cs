using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Patrulha : MonoBehaviour
{
    public float Vel = 50f;
    public float Rad = 50f;
    public float Rota = 0f;
    public GameObject Centro_Cidade;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Rota == 360)
        {
            Rota = 0;
        }
        if (Vector3.Distance(Centro_Cidade.transform.position, gameObject.transform.position) > 300.55f)
        {
            gameObject.transform.LookAt(Centro_Cidade.transform.position);
            gameObject.transform.Translate(0, 0, Vel * Time.deltaTime);
        }
        else
        {
            Rota += Rad * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(0, Rota, 0);
            gameObject.transform.Translate(0, 0, Vel * Time.deltaTime);
        }

    }
}