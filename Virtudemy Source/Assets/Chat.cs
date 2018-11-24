using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : MonoBehaviour {

	public List<string> chatHistory = new List<string> ();

	private string currentMessage = string.Empty;

	private void Send()
	{
		if(!string.IsNullOrEmpty(currentMessage.Trim()))
		{
			GetComponent<NetworkView> ().RPC ("ChatMessage", RPCMode.AllBuffered, new object[] { currentMessage });
			currentMessage = string.Empty;
		}
	}

	private void Bottom()
	{
		currentMessage = GUI.TextField(new Rect(0,Screen.height - 20, 175, 20), currentMessage);
		if(GUI.Button(new Rect(200, Screen.height-20,75,20),"Send"))
		{
			Send();
		}
		GUILayout.Space (15);
		for(int i=chatHistory.Count-1;i>=0;i--)
			GUILayout.Label(chatHistory[i]);

	}

	private void Top()
	{
		GUILayout.Space (15);


		GUILayout.BeginHorizontal (GUILayout.Width (250));
		currentMessage = GUILayout.TextField (currentMessage);
		if(GUILayout.Button("SEND"))
		{
			Send();
		}
		GUILayout.EndHorizontal();

		foreach(string c in chatHistory)
			GUILayout.Label(c);

	}
	private void OnGUI()
	{   

		Bottom ();

	}

	[RPC]

	public void ChatMessage(string message)
	{
		chatHistory.Add (message);
	}

}

