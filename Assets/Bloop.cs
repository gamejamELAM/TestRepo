using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Physics2D.OverlapCircle(Vector2.zero, 0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
