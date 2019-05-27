using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour
{
    public Material grassMat;
    public float movement;
    public float density;
    public float strength;

    // Start is called before the first frame update
    void Start()
    {
        movement = 10f;
        density = 0.1f;
        strength = 0.3f;

        grassMat.SetVector("Vector2_438498F8", new Vector4(movement, 0, 0, 0));
        grassMat.SetFloat("Vector1_9C114117", density);
        grassMat.SetFloat("Vector1_9D3571E0", strength);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement += 1f;
            grassMat.SetVector("Vector2_438498F8", new Vector4(movement, 0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement -= 1f;
            if(movement < 10f)
            {
                movement = 10f;
            }
            grassMat.SetVector("Vector2_438498F8", new Vector4(movement, 0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            density -= 0.1f;
            if(density < 0.1f)
            {
                density = 0.1f;
            }
            grassMat.SetFloat("Vector1_9C114117", density);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            density += 0.1f;
            grassMat.SetFloat("Vector1_9C114117", density);
        }  
        if (Input.GetKeyDown(KeyCode.Period))
        {
            strength += 0.3f;
            grassMat.SetFloat("Vector1_9D3571E0", strength);
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            strength -= 0.3f;
            if(strength < 0.3f)
            {
                strength = 0.3f;
            }
            grassMat.SetFloat("Vector1_9D3571E0", strength);
        } 
    }
}
