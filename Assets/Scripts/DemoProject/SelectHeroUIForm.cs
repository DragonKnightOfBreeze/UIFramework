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
	///脚本：选择英雄窗体管理
	///</summary>
	public class SelectHeroUIForm : BaseUIForm {

		public void Awake(){
			//窗体的性质
			base.CurrentUIType.UIForms_ShowType = UIFormShowType.ReverseChange;

			//注册事件（进入主城）
			RigisterButtonObjectEvent("Btn_Confirm",p=> {
				OpenUIForm(ProjectConst.UIFORM_MajorCity);
				OpenUIForm(ProjectConst.UIFORM_HeroInfo);
			});
			//注册事件（返回到登录窗体）
			RigisterButtonObjectEvent("Btn_Close", p=> {
				CloseUIForm();
			});
		}


		//public void Start(){

			////显示“UI管理器”内部的状态
			//print("所有窗体集合中的数量："+UIManager.GetInstance().ShowAllUIFormCount());
			//print("当前窗体集合中的数量：" + UIManager.GetInstance().ShowCurrentUIFormCount());
			//print("栈窗体集合中的数量：" + UIManager.GetInstance().ShowCurrentStackUIFormCount());
		//}

	}
}