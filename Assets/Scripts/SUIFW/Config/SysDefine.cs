/***
 * 标题：
 * 框架核心参数
 *
 * 功能：
 * 1.系统常量
 * 2.全局性方法
 * 3.系统枚举类型
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
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

//using Kernel;
//using Global;

namespace SUIFW {

	#region 【系统枚举类型】

	/// <summary>
	/// 枚举：UI窗体类型
	/// </summary>
	public enum UIFormType {
		/// <summary>
		/// 普通窗体
		/// </summary>
		Normal,
		/// <summary>
		/// 固定窗体
		/// </summary>
		Fixed,
		/// <summary>
		/// 弹出窗体
		/// </summary>
		PopUp
	}

	/// <summary>
	/// 枚举：UI窗体的显示类型
	/// </summary>
	public enum UIFormShowType {
		/// <summary>
		/// 普通
		/// </summary>
		Normal,
		/// <summary>
		/// 反向切换（模态，堆栈）（可以通过取消按钮退出）
		/// </summary>
		ReverseChange,
		/// <summary>
		/// 隐藏其他
		/// </summary>
		HideOther
	}

	/// <summary>
	/// 枚举：UI窗体的透明度类型
	/// </summary>xxc
	public enum UIFormLucenyType {
		/// <summary>
		/// 完全透明，不能穿透（模态）
		/// </summary>
		Lucency,
		/// <summary>
		/// 半透明，不能穿透（模态）
		/// </summary>
		Translucency,
		/// <summary>
		/// 低透明度，不能穿透（模态）
		/// </summary>
		Impenetrable,
		/// <summary>
		/// 可以穿透
		/// </summary>
		Pentrate
	}



	#endregion 【系统常量】

	public static class SysDefine {
		/* 路径常量 */
		/// <summary>
		/// 路径：画布
		/// </summary>
		public const string PATH_Canvas = "Prefabs/UI/Canvas";

		/* 标签常量 */
		/// <summary>
		/// 标签：画布
		/// </summary>
		public const string TAG_Canvas = "_Canvas";
		
		/* 节点常量 */
		public const string NODE_Normal = "Normal";
		public const string NODE_Fixed = "Fixed";
		public const string NODE_PopUp = "PopUp";
		public const string NODE_UIScripts = "ScriptsMgr";

		/* 其他常量 */
		public const float ADD_UICameraDepth = 100;

		/* 全局性的方法*/
		//TODO

		/* 委托的定义 */
		//TODO

	}
}