using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private Animator anim;

    public float trampolineForce;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("jump");
            AudioController.currentAudio.PlayMusic(AudioController.currentAudio.trampoline);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, trampolineForce), ForceMode2D.Impulse);

        }
    }
}
