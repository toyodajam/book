using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

public class ChangeBlock : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManager script;
    [SerializeField]
    private GameManager script2;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
       // Debug.Log(script);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(){

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Debug.Log(script);
            Destroy(this.gameObject);
            //script.BreakBlock();
        }

    }


}
