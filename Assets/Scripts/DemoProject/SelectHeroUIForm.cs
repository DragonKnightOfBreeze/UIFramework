/***
 * 标题：
 * 选择英雄窗体
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
	///类：选择英雄窗体管理
	///</summary>
	public class SelectHeroUIForm : BaseUIForm {

		public void Awake(){
			//窗体的性质
			base.CurrentUIType.UIForms_ShowType = UIFormShowType.HideOther;

			//注册事件
			//TODO
		}


		public void Start(){

			//显示“UI管理器”内部的状态
			print("所有窗体集合中的数量："+UIManager.GetInstance().ShowAllUIFormCount());
			print("当前窗体集合中的数量：" + UIManager.GetInstance().ShowCurrentUIFormCount());
			print("栈窗体集合中的数量：" + UIManager.GetInstance().ShowCurrentStackUIFormCount());
		}

	}
}