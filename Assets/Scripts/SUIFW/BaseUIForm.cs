/***
 * 标题：
 * UI窗体的父类
 * 
 * 功能：
 * 定义四个生命周期
 * Display：显示状态（可以加载文字）
 * Hide：隐藏状态
 * ReDisplay：再显示状态
 * Freeze：冻结状态
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

namespace SUIFW {
	///<summary>
	///各种UI窗体的父类
	///</summary>
	public class BaseUIForm : MonoBehaviour {

		/* 字段 */

		private UIType _CurrentUIType = new UIType();

		/* 属性*/

		/// <summary>
		/// 属性：当前UI窗体类型
		/// </summary>
		public UIType CurrentUIType {
			get { return _CurrentUIType; }
			set { _CurrentUIType = value; }
		}



		#region 【虚公共方法】

		/// <summary>
		/// 虚公共方法：显示状态
		/// </summary>
		public virtual void Display() {
			this.gameObject.SetActive(true);
		}

		/// <summary>
		/// 虚公共方法：隐藏状态
		/// </summary>
		public virtual void Hiding() {
			this.gameObject.SetActive(false);
		}

		/// <summary>
		/// 虚公共方法：重新显示状态
		/// </summary>
		public virtual void Redisplay() {
			this.gameObject.SetActive(true);
		}

		/// <summary>
		/// 虚公共方法：冻结状态
		/// </summary>
		public virtual void Freeze() {
			this.gameObject.SetActive(false);
		}


		#endregion


	}
}