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
using UnityEngine.UI;

//using Kernel;
//using Global;

namespace DemoProject {
	///<summary>
	///脚本：登录窗体管理
	///</summary>
	public class LoginUIForm : BaseUIForm {

		public Text Txt_Title;
		public Button Btn_OK;

		public void Awake(){
			//定义本窗体的性质（默认数值）
			base.CurrentUIType.UIForms_Type = UIFormType.Normal;
			base.CurrentUIType.UIForms_ShowType = UIFormShowType.Normal;
			base.CurrentUIType.UIForms_LucencyType = UIFormLucenyType.Lucency;

			RigisterButtonObjectEvent("Btn_OK",p=>OpenUIForm(ProjectConst.UIFORM_SelectHero));
		}

		public void Start(){
			ShowText(Txt_Title, "LoginSystem");
			ShowText(Btn_OK, "Login");

			//if (Txt_Title) {
			//	Txt_Title.text =  LanguageMgr.GetInstance().GetText("LoginSystem");
			//}
			//if (Btn_OK) {
			//	Btn_OK.text = LanguageMgr.GetInstance().GetText("LoginSystem");
			//}
		}

	}
}