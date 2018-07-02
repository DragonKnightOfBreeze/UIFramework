/***
 * 标题：
 * 
 * 
 * 功能：
 * 
 * 
 * 思路：
 * 
 * 
 * 改进：
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;

//using Kernel;
//using Global;

namespace DemoProject {
	///<summary>
	///类：开始项目
	///</summary>
	public class StartProject : MonoBehaviour {

		void Start() {
			//加载登录窗体
			UIManager.GetInstance().ShowUIForms("LoginUIForm");
		}



	}
}