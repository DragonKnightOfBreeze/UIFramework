/***
 * 标题：
 * 登录窗体
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
	///类：登录窗体管理类
	///</summary>
	public class LoginUIForm : BaseUIForm {

		public void Awake(){
			//定义本窗体的性质（默认数值）
			base.CurrentUIType.UIForms_Type = UIFormType.Normal;
			base.CurrentUIType.UIForms_ShowType = UIFormShowType.Normal;
			base.CurrentUIType.UIForms_LucencyType = UIFormLucenyType.Lucency;

			/* 给按钮注册事件 */
			//查找按钮结点
			//Transform tra_LoginUIForm = GameObject.FindGameObjectWithTag(SysDefine.TAG_LoginUIForm).transform;
			//Transform tra_Btn_OK = tra_LoginUIForm.Find("BG/Btn_OK");
			Transform tra_Btn_OK =  UnityHelper.FindChildNode(gameObject, "Btn_Ok");

			//给按钮结点注册方法
			if (tra_Btn_OK != null) {
				EventTriggerListener.GetListener(tra_Btn_OK.gameObject).onClick += LoginSys;
			}
		}


		public void LoginSys(GameObject go){
			//前台或者后台检查用户名和用户密码
			//TODO
			//如果成功，则进入下一个窗体
			UIManager.GetInstance().ShowUIForms("SelectHeroUIForm");
		}



	}
}