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
	///脚本：登录窗体管理
	///</summary>
	public class LoginUIForm : BaseUIForm {

		public void Awake(){
			//定义本窗体的性质（默认数值）
			base.CurrentUIType.UIForms_Type = UIFormType.Normal;
			base.CurrentUIType.UIForms_ShowType = UIFormShowType.Normal;
			base.CurrentUIType.UIForms_LucencyType = UIFormLucenyType.Lucency;

			RigisterButtonObjectEvent("Btn_OK",p=>OpenUIForm(ProjectConst.UIFORM_SelectHero));
		}
	}
}