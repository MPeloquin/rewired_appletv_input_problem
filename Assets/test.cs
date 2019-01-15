using UnityEngine;

public class test : MonoBehaviour
{
	private Rewired.Player _player;

	private void Start()
	{
		_player = Rewired.ReInput.players.GetPlayer(0);
		UnityEngine.tvOS.Remote.allowExitToHome = false;
	}

	private void Update() {
		if(_player.GetButtonDown("UIPlay"))
			Debug.Log("Play");
            
		if(_player.GetButtonDown("UICancel"))
			Debug.Log("Cancel");
		
		if(_player.GetButtonDown("UISubmit"))
			Debug.Log("Submit");
	}
}

