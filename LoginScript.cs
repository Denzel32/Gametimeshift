using UnityEngine;
using System.Collections;

public class LoginScript : MonoBehaviour 
{
	public string postURL = "http://localhost/Php/save.php";
	public string getURL = "http://localhost/Php/login.php";
	private string name = "";

	void OnGUI ()
	{
		GUI.Label ( new Rect ( 10, 10, 50, 25), "Name");
		name = GUI.TextField(new Rect(70,10,100,25), name);

		if(GUI.Button(new Rect( 180, 10, 80, 25), "Send name"))
		{
			StartCoroutine("SaveName");
		}

		if(GUI.Button (new Rect(10, 80, 80, 25), "Get name"))
		{
			StartCoroutine("LoadName");
		}
	}

	IEnumerator LoadName()
	{	
		print ("getting name from" + getURL);

		//print out the data returned here
		WWW  getName = new WWW (getURL);

		//wait for a response
		yield return getName;

		print(getName.text); 
	}

	IEnumerator SaveName()
	{	
		//create new string to where we will send the name
		string urlString = postURL + "?name=" + WWW.EscapeURL(name);

		print ( "sending" + urlString);

		//send the data
		WWW postName = new WWW (urlString);

		//wait for response
		yield return postName;

		print (postName.text);
	}

}
