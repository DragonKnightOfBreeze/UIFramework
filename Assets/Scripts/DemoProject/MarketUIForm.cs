/***
 * 标题：
 * 商城窗体管理
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
	///脚本：商城窗体管理
	///</summary>
	public class MarketUIForm : BaseUIForm {

		void Awake(){
			//窗体性质
			CurrentUIType.UIForms_Type = UIFormType.PopUp;
			CurrentUIType.UIForms_ShowType = UIFormShowType.ReverseChange;
			CurrentUIType.UIForms_LucencyType = UIFormLucenyType.Translucency;

			//注册事件（退出按钮）
			RigisterButtonObjectEvent("Btn_Close",p=>CloseUIForm());

		}



	}
}