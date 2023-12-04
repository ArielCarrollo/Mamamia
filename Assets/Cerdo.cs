using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerdo : MonoBehaviour
{
    private AudioSource Mamamia;
    private Animator _animator;
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        Mamamia = GetComponent<AudioSource>();
    }
  

    // Update is called once per frame
  
    private void OnTriggerEnter2D(Collider2D collision3)
    {
        if (collision3.gameObject.tag == "Huevo")
        {
            _animator.SetBool("Ex", true);
            Mamamia.Play();
            Invoke("Explotar", 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision5)
    {
        if (collision5.gameObject.tag == "Huevo")
        {
            Destroy(this.gameObject);
        }
    }
    void Explotar()
    {

        Destroy(this.gameObject);
    }
 
}
