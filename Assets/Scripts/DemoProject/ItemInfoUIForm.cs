/***
 * 标题：
 * 物品详细信息窗体管理
 * 
 * 功能：
 * 显示各种道具信息
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
	/// <summary>
	/// 脚本：物品详细信息窗体管理
	/// </summary>
	public class ItemInfoUIForm : BaseUIForm {

		public Text Txt_Name;
		//public Text Txt_Desc;

		void Awake() {
			//窗体性质
			CurrentUIType.UIForms_Type = UIFormType.PopUp;
			CurrentUIType.UIForms_ShowType = UIFormShowType.ReverseChange;
			CurrentUIType.UIForms_LucencyType = UIFormLucenyType.Translucency;


			//注册事件（关闭按钮）
			RigisterButtonObjectEvent("Btn_Close", p => CloseUIForm());

			//接受消息，显示文字信息
			ReceiveMessage("Items", p => {
				//利用资源国际化的方式（不需要主动提供Value，改为从Json文件中获取）
				//ShowText(Txt_Name, p.Key);

				if (Txt_Name) {
					Txt_Name.text = p.Value.ToString();

					//传递多个字符串
					//string[] stringArray = p.Value as string[];
					//Txt_Name.text = stringArray[0];
					//Txt_Desc.text = stringArray[1];
				}
			});
			

		}



	}
}