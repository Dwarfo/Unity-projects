using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

    public float speed = 1;
    private Rigidbody2D rbody;
    private Animator anim;
    private Transform rotate;
   // public Rigidbody2D projectile;
    public float FireForce = 5f;

    private bool fired = false;
    private string FireButton;
    private Vector3 rotation_n;
    private Vector3 rotation_p;
    //[HideInInspector]
    public Vector2 movement_vec;

    // Use this for initialization
    void Awake ()
    {
        FireButton = "Fire1";
        rotate = GetComponent<Transform>();
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rotation_n = new Vector3(-1*rotate.localScale.x,rotate.localScale.y,1);
        rotation_p = new Vector3(rotate.localScale.x, rotate.localScale.y, 1);
       
}
  

	// Update is called once per frame
	public void Update ()
    {
        movement_vec = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement_vec != Vector2.zero)
        {
            if (movement_vec.x == -1)
                rotate.localScale = rotation_n;
            else
                rotate.localScale = rotation_p;
                anim.SetBool("IsWalking", true);
                anim.SetFloat("Input_x", movement_vec.x);
                anim.SetFloat("Input_y", movement_vec.y);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
        rbody.MovePosition(rbody.position + movement_vec * Time.deltaTime * speed);

        if (Input.GetButtonDown(FireButton) && !fired)
        {
            anim.SetBool("Attack", true);
            fired = true;
        }

        if (Input.GetButtonUp(FireButton))
        {
            anim.SetBool("Attack", false);
            fired = false;
        }
        
    }

    /*private void Fire()
    {
        Vector3 pos = (rbody.transform.position + new Vector3(0, 0.915f));
        projectile.transform.position = pos;
        Rigidbody2D projectileInst = Instantiate(projectile, projectile.transform) as Rigidbody2D;

        projectileInst.velocity = FireForce * projectile.transform.forward;
    }*/
}
