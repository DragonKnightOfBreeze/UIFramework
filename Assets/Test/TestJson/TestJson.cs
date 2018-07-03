/***
 * 标题：
 * Json测试
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
using UnityEngine;

//using Kernel;
//using Global;

namespace Test {
	///<summary>
	///
	///</summary>
	public class TestJson : MonoBehaviour {

		void Start() {
			TextAsset ta = Resources.Load<TextAsset>("BreezeKatana");

			//方法1：Json的序列化工作（对象到Json文件）
			BreezeKatana bk =  JsonUtility.FromJson<BreezeKatana>(ta.text);
			//显示对象中数据
			Debug.Log("");
			Debug.Log(string.Format("Name_CN ={0},Name_EN = {1},Type = {2},ImpType ={3},ATK = {4}",bk.Name_CN,bk.Name_EN,bk.Type,bk.ImpType,bk.ATK));
			}

			//方法2：Json的反序列化工作（Json文件到对象）
			


			//方法3：测试覆盖反序列化输出

		

	}
}