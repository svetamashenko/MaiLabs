using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum RotationStatus { Right = 0, Left = 180 }
public class GirlBehaviour : MonoBehaviour
{
    GameObject Girl;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator girlAnimator;
    private int NumbOfPlatforms = PrefsClass.platformsNumb - 1;
    public int PieCount = 0;

    public float maxSpeed = 0.5f;

    bool facingRight = false;

    bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        grounded = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float move = 0;
        if (Input.GetAxis("Horizontal") != 0)
            move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        grounded = girlAnimator.GetBool("is_grounded");
        if (move == 0 && grounded == true)
            girlAnimator.Play("GirlIddleAnimation");
        if (rb.velocity.y == 0)
        {
            rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y + 5 * maxSpeed * jump);
            if (jump == 0)
                girlAnimator.SetBool("is_grounded", true);
            else girlAnimator.SetBool("is_grounded", false);
        }
        girlAnimator.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        if (move > 0 && facingRight == false) Flip();
        else if (move < 0 && facingRight == true) Flip();

        if ((gameObject.GetComponent<Transform>().position.x < 0.5) && (gameObject.GetComponent<Transform>().position.x > -0.5) && (gameObject.GetComponent<Transform>().position.y > NumbOfPlatforms - 0.1f))
        {
            Destroy(gameObject);
            PrefsClass.PickedPies = PieCount;
            GoToNextScene(2);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        sr.flipX = !sr.flipX;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PieCount++;
        Destroy(other.gameObject);
    }
    public void GoToNextScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
