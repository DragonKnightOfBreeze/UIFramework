/***
 * 标题：
 * 主城窗体
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
	///脚本：主城窗体管理
	///</summary>
	public class MajorCityUIForm : BaseUIForm {
		
		public void Awake() {
			//窗体性质
			CurrentUIType.UIForms_ShowType = UIFormShowType.HideOther;

			//注册事件（打开商城窗体）
			RigisterButtonObjectEvent("Btn_FirstPay", p=>OpenUIForm(ProjectConst.UIFORM_Market));
		}



	}
}