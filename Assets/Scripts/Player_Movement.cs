using UnityEngine;

public class Player_Movement : MonoBehaviour
{

//TODO: change input direction mouse position so the player follows the mouse
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 75f;

	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
