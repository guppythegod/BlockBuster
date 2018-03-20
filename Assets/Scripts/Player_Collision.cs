using UnityEngine;

public class Player_Collision : MonoBehaviour {
	public Player_Movement movement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			Debug.Log("player hit an obstacle !!");
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
