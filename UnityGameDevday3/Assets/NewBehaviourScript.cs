using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    int x;
   public Rigidbody2D padel;
    void Start()
    {
        padel = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        padel.velocity = new Vector2(Input.GetAxis("Horizontal"), 0f) * 20;
    }
}
