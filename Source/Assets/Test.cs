using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public void ExternalCall() {
		Application.ExternalCall("MyFunction1");
		// Calls MyFunction2 in the web page with a string
		Application.ExternalCall("MyFunction2", "Hello from Unity!");
		// Calls MyFunction3 in the web page with several arguments of different types
		Application.ExternalCall("MyFunction3", "one", 2, 3.0F);
	}

	public void ExternalEval() {
		Application.ExternalEval("alert('hoge');");
	}
}
