using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllInOneMarte : NavePai
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
    public GameObject winnerTerra;
    public GameObject canvasPrincipal;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(0, moveAmount, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            transform.Translate(0, moveAmount, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -turnAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -turnAmount);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            Shoot();
        }

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            FindAnyObjectByType<GameManager>().EndGame();
            winnerTerra.SetActive(true);
            canvasPrincipal.SetActive(false); // Colocar no game manager, usando bool
        }

    }

    void Shoot()
    {
        shootingPoint.rotation = gameObject.transform.rotation;
        Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
    }

    public override void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        base.TakeDamage(damage);
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.name == "Bullet-Earth(Clone)")
    //    {

    //        currentHealth -= damage;

    //        healthBar.SetHealth(currentHealth);
    //    }
    //}
}