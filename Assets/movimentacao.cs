using JetBrains.Annotations;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKey("d")) ;
        transform.Translate(1, 0, 0);
        transform.Translate(0, 1, 0);
        Physics.CheckSphere(transform.position,if);
    }
}
