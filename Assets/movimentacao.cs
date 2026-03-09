using UnityEngine;

public class movimentacao : MonoBehaviour
{
    float vida = 100;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(0.01f, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-0.01f, 0, 0);
        }
        if (Input.GetKey("w")) { 
                transform.Translate(0, 0.01f, 0); 
                    
         }
    }
    //Destroy(this.gameobject);
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bomba")
        {
            vida = vida - 100f;
            Debug.Log("morreu");
        }
    }
}
