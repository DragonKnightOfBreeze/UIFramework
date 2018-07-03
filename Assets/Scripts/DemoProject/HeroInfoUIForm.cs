/***
 * 标题：
 * 英雄信息显示窗体
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
	///脚本：英雄信息显示窗体管理
	///</summary>
	public class HeroInfoUIForm : BaseUIForm {

		public void Awake() {
			//窗体性质
			base.CurrentUIType.UIForms_Type = UIFormType.Fixed;	//固定在主窗体上面显示

			//注册事件
		}



	}
}