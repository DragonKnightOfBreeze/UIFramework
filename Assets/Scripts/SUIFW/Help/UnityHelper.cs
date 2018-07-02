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
		/// 帮助公共方法：递归查找子节点对象
		/// </summary>
		/// <param name="goParent">父对象</param>
		/// <param name="childName">指定的子对象名字</param>
		/// <returns>要查找的子对象的方位</returns>
		public static Transform FindChildNode(GameObject goParent, string childName){
			//查找直接的子节点
			Transform searchTra = goParent.transform.Find(childName);	
			//如果还没有查找到
			if (searchTra == null) {
				//如果还有子节点
				if (goParent.transform.childCount != 0) {
					foreach (Transform tra in goParent.transform) {
						FindChildNode(tra.gameObject, childName);
						//searchTra = FindChildNode(tra.gameObject, childName);
						//if (searchTra != null) {
						//	return searchTra;
						//}
					}
				}
				return null;
			}
			return searchTra;
		}


		/// <summary>
		/// 帮助公共方法：获取子节点的脚本
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
		/// 帮助公共方法：向子节点添加脚本
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="goParent"></param>
		/// <param name="childName"></param>
		/// <returns></returns>
		public static T AddScriptsToChild<T>(GameObject goParent, string childName)
		where T : Component{
			//查找指定的子节点
			Transform searchTra = FindChildNode(goParent, childName);
			//如果查找成功，则考虑是否已经有相同的脚本，，否则直接添加
			if (searchTra != null) {
				//如果已经有相同的脚本，则删除
				T[] componentArray = searchTra.GetComponents<T>();
				foreach (var script in componentArray) {
					if (script != null) {
						Destroy(script);
					}
				}
				return searchTra.gameObject.AddComponent<T>(); 
			}
			//如果查找不成功，则返回null
			return null;
		}



	}
}