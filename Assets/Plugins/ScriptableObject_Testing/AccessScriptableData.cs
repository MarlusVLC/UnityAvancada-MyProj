using UnityEngine;
using System.Collections;
using UnityEditor;

public class AccessScriptableData : MonoBehaviour {

	public UnitData unitData, unitDataInMemory;
	public string unitDataPath;

	void Start () {
		// Acessa dado em disco, se associado o unitData a uma instância do projeto
		Debug.Log (unitData.Actions[0].ActionName);

		// Criar instancia em memória; O 1o. não funciona para scriptable Object, usar formato abaixo:
		//unitData = new UnitData();
		unitDataInMemory = ScriptableObject.CreateInstance<UnitData>();

		// Copiando dados em disco para uma instância temporária em memória
		unitDataInMemory = unitData.Clone();
	}

	[ContextMenu("Print Actions Names")]
	private void PrintActions()
	{
		foreach (var action in unitData.Actions)
		{
			Debug.Log(action.ActionName);
		}
	}

	[ContextMenu("Save in Hard Drive")]
	private void SaveInHardDrive()
	{
		AssetDatabase.CreateAsset(unitDataInMemory, unitDataPath);
	}
}
