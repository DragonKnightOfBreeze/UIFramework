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
using UnityEngine.Networking;
using UnityEngine.UI;

//using Kernel;
//using Global;

namespace DemoProject {
	///<summary>
	///脚本：商城窗体管理
	///</summary>
	public class MarketUIForm : BaseUIForm {

		public Text Txt_Title;

		void Awake(){
			//窗体性质
			CurrentUIType.UIForms_Type = UIFormType.PopUp;
			CurrentUIType.UIForms_ShowType = UIFormShowType.ReverseChange;
			CurrentUIType.UIForms_LucencyType = UIFormLucenyType.Translucency;


			//注册事件（退出按钮）
			RigisterButtonObjectEvent("Btn_Close",p=>CloseUIForm());

			//注册事件（道具显示：胸甲Armour）
			RigisterButtonObjectEvent("Btn_Armour", p => {
				//打开子窗体
				OpenUIForm(ProjectConst.UIFORM_ItemInfo);
				//传递数据
				SendMessage(ProjectConst.MSGTYPE_Items,"Armour","皮胸甲");
			});
			//注册事件（道具显示：腿甲LegArmour）
			RigisterButtonObjectEvent("Btn_LegArmour", p => {
				//打开子窗体
				OpenUIForm(ProjectConst.UIFORM_ItemInfo);
				//传递数据
				SendMessage(ProjectConst.MSGTYPE_Items, "LegArmour", "皮腿甲");
			});

			//注册事件（道具显示：靴子Boots）
			RigisterButtonObjectEvent("Btn_Boots", p => {
				//打开子窗体
				OpenUIForm(ProjectConst.UIFORM_ItemInfo);
				//传递数据
				SendMessage(ProjectConst.MSGTYPE_Items, "Boots", "皮靴");
			});

			//注册事件（道具显示：法杖Staff）
			RigisterButtonObjectEvent("Btn_Staff", p => {
				//打开子窗体
				OpenUIForm(ProjectConst.UIFORM_ItemInfo);
				//传递数据
				SendMessage(ProjectConst.MSGTYPE_Items, "Staff", "水晶法杖");
				//传递数据（多个字符串）
				//string[] stringArray = new string[]{"水晶法杖","彼海姆龙学院的法师们使用的法杖。"};
				//SendMessage("Item","Staff",stringArray);
			});

			//注册事件（道具显示：戒指Ring）
			RigisterButtonObjectEvent("Btn_Ring", p => {
				//打开子窗体
				OpenUIForm(ProjectConst.UIFORM_ItemInfo);
				//传递数据
				SendMessage(ProjectConst.MSGTYPE_Items, "Ring", "蓝宝石戒指");
			});

		}

		void Start(){
			ShowText(Txt_Title, "MarketSys");
		}

	}
}