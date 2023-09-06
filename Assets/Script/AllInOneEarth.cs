using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllInOneEarth : NavePai
{
    public float turnSpeed = 250f;
    public float moveSpeed = 15f;    
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public HealthBar healthBar;
    public int maxHealth = 5;
	public int currentHealth;
    public GameObject nave;
    public GameManager gameManager;
    public GameObject winnerMarte;
    public GameObject canvasPrincipal;
    public int damage = 1;

    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(0, moveAmount, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(0, moveAmount, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -turnAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -turnAmount);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }  
        
        if (currentHealth <= 0)
		{
            gameObject.SetActive(false);
            FindAnyObjectByType<GameManager>().EndGame();
            winnerMarte.SetActive(true);
            canvasPrincipal.SetActive(false); // Colocar no game manager, usando bool
        }

    }
    
    void Shoot()
    {
        shootingPoint.rotation = gameObject.transform.rotation; 
        Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation); 
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Bala"))
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
            base.TakeDamage(damage);
        }
    }
}

    //public override void TakeDamage(int damage)
    //{
        //currentHealth -= damage;
        //healthBar.SetHealth(currentHealth);
        //base.TakeDamage(damage);
    //}

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.name == "Bullet(Clone)")
    //    {

    //        currentHealth -= damage;

    //        healthBar.SetHealth(currentHealth);
    //    }
    //}


  