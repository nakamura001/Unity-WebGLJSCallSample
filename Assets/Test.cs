using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
	public Text resText;

	void Start() {
		#if !UNITY_EDITOR && UNITY_WEBGL
		WebGLInput.captureAllKeyboardInput = false;
		#endif
	}

	public void ExternalCall1() {
		Application.ExternalCall("MyFunction1");
	}

	public void ExternalCall2() {
		Application.ExternalCall("MyFunction2", "Hello from Unity!");
	}

	public void ExternalCall3() {
		Application.ExternalCall("MyFunction3", "one", 2, 3.0F);
	}

	public void ExternalEval() {
		Application.ExternalEval("alert('hoge');");
	}

	public void FromJS(string val) {
		resText.text = val;
	}
}
