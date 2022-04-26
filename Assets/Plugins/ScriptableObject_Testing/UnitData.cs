using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "New Unit Data")]
public class UnitData : ScriptableObject {
	
	public ActionTypes[] Actions;

	[System.Serializable]
	public struct ActionTypes {
		public int Idx;
		public string ActionName;

		public void Anulate()
		{
			Idx = 0;
			ActionName = "";
		}
	}

	public UnitData Clone() {
		var NewUnitData = CreateInstance<UnitData>();

		NewUnitData.Actions = (ActionTypes[])Actions.Clone();

		return NewUnitData;
	}
	
	[ContextMenu("Delete Last Item")]
	private void DeleteLastItem()
	{
		Actions[Actions.Length - 1].Anulate();
	}

}
