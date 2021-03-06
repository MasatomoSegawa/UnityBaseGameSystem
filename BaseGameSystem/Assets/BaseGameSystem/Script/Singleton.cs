﻿using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance;
	public static T Instance {
		get {
			if (instance == null) {
				instance = (T)FindObjectOfType (typeof(T));
				
				if (instance == null) {
					Debug.LogError (typeof(T) + "is nothing");
				}
			}
			
			return instance;
		}
	}
	
	protected void Awake()
	{
		CheckInstance();
	}
	
	protected bool CheckInstance()
	{
		if(this == Instance){ return true;}
		Destroy(this.gameObject);
		return false;
	}
}
