using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float delayTime = 2f;

	public GameObject completeLevelUI;
	public void EndGame()
	{
		if (!gameHasEnded)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", delayTime);
		}
	}

	public void CompleteLevel()
	{
		Debug.Log("Level Complete !");
		completeLevelUI.SetActive(true);
		Invoke("FinishGame", delayTime - 1f);
	}
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void FinishGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
