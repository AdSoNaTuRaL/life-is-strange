using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool exibirPainel;

    Animator anim;
    Rigidbody2D rb;


    public GameObject textoLivro;
    public GameObject textoFaca;
    public GameObject textoPeso;
    public GameObject textoFriends;
    public GameObject textoFruits;
    public GameObject textoMusic;
    public GameObject textoSleep;
    public GameObject textoPassaFase;

    public float forcaPulo;
    public bool estaNoChao;
    public Transform refPe;
    public float velX;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Pontuation.playerScore += Time.deltaTime;

        //Mover horizontalmente
        float movX;
        movX = Input.GetAxis("Horizontal");
        anim.SetFloat("absolutoMovimentoX", Mathf.Abs(movX));
        rb.velocity = new Vector2(velX * movX, rb.velocity.y);

        //Detectar se o personagem está no chão
        estaNoChao = Physics2D.OverlapCircle(refPe.position, 1f, 1 << 8);
        anim.SetBool("estaNoChao", estaNoChao);

        //Pular
        if (Input.GetButtonDown("Jump") && estaNoChao)
        {
            rb.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
            GetComponent<AudioSource>().Play();
        }

        //Virar o personagem de acordo com sua posição
        if (movX < 0) GetComponent<SpriteRenderer>().flipX = true;
        if (movX > 0) GetComponent<SpriteRenderer>().flipX = false;
    }

    //Força do Trampolim
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trampolim"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 50f);
        }
    }

    //Colidindo com objetos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LivroMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(true);
            textoFaca.SetActive(false);
            textoPeso.SetActive(false);
            textoFriends.SetActive(false);
            textoFruits.SetActive(false);
            textoMusic.SetActive(false);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(false);
        }

        if (collision.gameObject.CompareTag("CuchilloMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(true);
            textoPeso.SetActive(false);
            textoFriends.SetActive(false);
            textoFruits.SetActive(false);
            textoMusic.SetActive(false);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(false);
        }

        if (collision.gameObject.CompareTag("PesoMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(false);
            textoPeso.SetActive(true);
            textoFriends.SetActive(false);
            textoFruits.SetActive(false);
            textoMusic.SetActive(false);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(false);
        }

        if (collision.gameObject.CompareTag("FriendsMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(false);
            textoPeso.SetActive(false);
            textoFriends.SetActive(true);
            textoFruits.SetActive(false);
            textoMusic.SetActive(false);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(false);
        }

        if (collision.gameObject.CompareTag("FruitsMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(false);
            textoPeso.SetActive(false);
            textoFriends.SetActive(false);
            textoFruits.SetActive(true);
            textoMusic.SetActive(false);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(false);
        }

        if (collision.gameObject.CompareTag("MusicMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(false);
            textoPeso.SetActive(false);
            textoFriends.SetActive(false);
            textoFruits.SetActive(false);
            textoMusic.SetActive(true);
            textoSleep.SetActive(false);
            textoPassaFase.SetActive(false);
        }

        if (collision.gameObject.CompareTag("SleepMensagem"))
        {
            exibirPainel = true;
            textoLivro.SetActive(false);
            textoFaca.SetActive(false);
            textoPeso.SetActive(false);
            textoFriends.SetActive(false);
            textoFruits.SetActive(false);
            textoMusic.SetActive(false);
            textoMusic.SetActive(false);
            textoSleep.SetActive(true);
            textoPassaFase.SetActive(false);
        }
    }
}
