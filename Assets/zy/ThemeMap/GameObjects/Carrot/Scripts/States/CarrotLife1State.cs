﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class CarrotLife1State : FSMState<Carrot, Carrot.States> {
	
	public override Carrot.States StateID {
		get {
			return Carrot.States.life1;
		}
	}
	
	public override void Enter () {
		Animator animator = this.entity.GetComponent<Animator> ();
		animator.Play("CarrotLife1");
	}
	
	public override void Execute ()
	{
		//touch event
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//从摄像机发出到点击坐标的射线
			RaycastHit hitInfo;
			if(Physics.Raycast(ray,out hitInfo)) {

			}
		}
	}
	
	public override void Exit () {

	}
}
