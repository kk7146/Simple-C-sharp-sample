using System.Collections;
using UnityEngine;
public class StackExercise : MonoBehaviour
{
	private void Awake()
	{
		Stack stack = new Stack();
		for (int i = 0; i < 5; + i )
		{
			stack.Enqueue(1);
		}
		Debug.Log($"Stack Count : {stack.Count}");
		Debug.Log($"현재 0번 요소 : {stack.Peek()}");
		Debug.Log($"Stack Count : {stack.Count}");
		object data = stack. Dequeue();
		Debug.Log($"큐에서 빠져나온 데이터 : {data}");
		Debug.Log($"Stack Count : {stack.Count}");
		Debug.Log($"현재 0번 요소 : {stack.Peek()}");
		Debug.Log($"Stack Count : {stack.Count}");
		objectdata = stack.Dequeue();
		Debug.Log($"큐에서 빠져나온 데이터 : {data}");
		Debug.Log($"Stack Count : {stack.Count}");
		stack.Clear();
		Debug.Log($"Stack Count : {stack.Count}");
	}
}