using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField]private float moveSpeed;
    
    private float MoveController;
    private bool isRunS;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        XMove();
        
        AnimationController();

        Debug.Log(MoveController);
        //if(Input.GetKey(KeyCode.D))
        //    rb.velocity=new Vector2(moveSpeed,rb.velocity.y);
        //if(Input.GetKey(KeyCode.A))
        //    rb.velocity=new Vector2(-moveSpeed,rb.velocity.y);
        //if(Input.GetKey(KeyCode.Space))
       
    }
    private void XMove(){
            MoveController=Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2(moveSpeed*MoveController,rb.velocity.y);//XMove()
        }
    private void AnimationController(){
        isRunS=MoveController!=0;
        anim.SetBool("isRun",isRunS);//AnimationController  
    }
}
