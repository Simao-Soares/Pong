using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;


    private void Update()
    {
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)){ 
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow)){
            _direction = Vector2.down;
        } else {
            _direction = Vector2.zero;        
        }
    }

    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0){
            _rigidbody.AddForce(_direction * this.speed);
        }
    }

    public void Grow()
    {
        this.transform.localScale += new Vector3(0.0f, 0.5f, 0.0f);
    }

        public void Shrink()
    {
        this.transform.localScale += new Vector3(0.0f, -0.5f, 0.0f);
    }
}
 