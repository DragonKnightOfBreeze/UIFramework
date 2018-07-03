/***
 * 标题：
 * Unity帮助脚本
 * 
 * 功能：
 * 提供程序用户一些常用的功能方法的实现，方便程序员快速开发
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
using UnityEngine;

//using Kernel;
//using Global;

namespace SUIFW {
	///<summary>
	///Unity帮助类
	///</summary>
	public class UnityHelper : MonoBehaviour {

		/// <summary>
		/// 公共方法：递归查找子节点对象
		/// </summary>
		/// <param name="goParent">父对象</param>
		/// <param name="childName">指定的子对象名字</param>
		/// <returns>要查找的子对象的方位</returns>
		public static Transform FindChildNode(GameObject goParent, string childName){
			//查找直接的子节点
			Transform searchTra = goParent.transform.Find(childName);	
			//如果还没有查找到
			if (searchTra == null) {
				////如果还有子节点
				//if (goParent.transform.childCount != 0) {
					foreach (Transform tra in goParent.transform) {
						searchTra =  FindChildNode(tra.gameObject, childName);
					}
				//}
				//return null;
			}
			return searchTra;
		}


		/// <summary>
		/// 公共方法：获取子节点的脚本
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="goParent">父对象</param>
		/// <param name="childName">指定的子对象名称</param>
		/// <returns></returns>
		public static T GetComponentInChilldNode<T>(GameObject goParent, string childName) 
		where T:Component{
			//查找指定的子节点
			Transform searchTra = FindChildNode(goParent, childName);
			if (searchTra != null) {
				return searchTra.gameObject.GetComponent<T>();
			}
			return null;
		}


		/// <summary>
		/// 公共方法：向子节点添加脚本
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="goParent"></param>
		/// <param name="childName"></param>
		/// <returns></returns>
		public static T AddComponentToChild<T>(GameObject goParent, string childName)
		where T : Component{
			//查找指定的子节点
			Transform searchTra = FindChildNode(goParent, childName);
			//如果查找成功，则考虑是否已经有相同的脚本，否则直接添加
			if (searchTra != null) {
				//如果已经有相同的脚本，则删除
				T[] componentArray = searchTra.GetComponents<T>();
				foreach (var script in componentArray) {
					if (script.name == childName) {
						Destroy(script);
					}
				}
				return searchTra.gameObject.AddComponent<T>(); 
			}
			//如果查找不成功，则返回null
			return null;
		}

		/// <summary>
		/// 公共方法：给子节点添加父对象
		/// </summary>
		/// <param name="parent">父对象的方位</param>
		/// <param name="child">子对象的方位</param>
		public static void AddChildNodeToParentNode(Transform parent,Transform child){
			child.SetParent(parent,false);	//按照局部坐标
			child.localPosition = Vector3.zero;
			child.localScale = Vector3.one;
			child.localEulerAngles = Vector3.zero;
		}


	}
}