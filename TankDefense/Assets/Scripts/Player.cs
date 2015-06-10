using UnityEngine;

using System.Collections;

public class Player : MonoBehaviour
{

	public float velocidade;
	public Transform player;
	//private Animator animator;
	
	public bool isGrounded; //se esta no chao
	public float force;		//força do pulo em relaçao a Y
	
	public float jumpTime = 0.9f;	//tempo do pulo retirado o valor da animaçao 16frames
	public float jumpDelay = 0.9f;   //tempo de animaçao o valor vem da animaçao 16 frames
	public bool jumped;				//verifica se esta pulando
    //public float jumpSpeed = 10f;
	public Transform ground;		//sera utilizada com o objeto ground em branco que criou na unity.
	
	// Use this for initialization
	void Start () {
		
		//animator = player.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
    void Update()
    {
        Movimentar();

        // Verificando se o player está atirando.
        if (Input.GetButtonDown("Fire1"))
        {
            WeaponScript weapon = GetComponent<WeaponScript>();

            if (weapon != null && weapon.shootCooldown <= 0)
            {
                weapon.Attack();

                // Som de tiro do player.
                //SoundEffectScript.Instance.MakePlayerShotSound();
            }
        }
    }
	
	void Movimentar()
    {
		
		
		//animator.SetFloat("run", Mathf.Abs (Input.GetAxis("Horizontal")));
		
		//Movimento para a direita
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			//da uma velocidade ao deslocamento
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			//define qual o lado se deve movimentar
			transform.eulerAngles = new Vector2(0,0);
		}
		
		//Movimento para a esquerda
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			//da uma velocidade ao deslocamento
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			//define qual o lado se deve movimentar
			transform.eulerAngles = new Vector2(0,180);
		}
		
		
		
		
		
	}

    void FixedUpdate()
    {

        //Verifica a posiçao do menino, se esta no solo ou nao
		isGrounded = Physics2D.Linecast(this.transform.position,ground.position,1<<LayerMask.NameToLayer("Plataforma"));

         //botao que faz iniciar o Jump "Salto"
		if (Input.GetButtonDown ("Jump") && isGrounded && !jumped)
        {
			//adiciona força ao salto
			//rigidbody.AddForce(transform.up * force);
            //transform.Translate(Vector3.up * force);
            //GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpSpeed, ForceMode2D.Force);
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * force);
			//equipara o tempo de salto com o tempo de animaçao
			jumpTime = jumpDelay;
			//chama a animaçao do salto
			//animator.SetTrigger("jump");
			//doloca a variavel jumped como treu "saltando"
			//jumped = true;
    
         }

        jumpTime -= Time.deltaTime;
		
		if (jumpTime <= 0 && isGrounded && jumped)
        {
			
			//animator.SetTrigger("ground");
			//jumped = false;
		}
		
    }


}
