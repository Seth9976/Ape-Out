using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000052 RID: 82
	public static class UIElementsRuntimeUtility
	{
		// Token: 0x0600015E RID: 350 RVA: 0x000093FC File Offset: 0x000075FC
		public static EventBase CreateEvent(Event systemEvent)
		{
			return UIElementsUtility.CreateEvent(systemEvent, systemEvent.rawType);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000941C File Offset: 0x0000761C
		public static void DisposeRuntimePanel(ScriptableObject ownerObject)
		{
			Panel panel;
			bool flag = UIElementsUtility.TryGetPanel(ownerObject.GetInstanceID(), out panel);
			if (flag)
			{
				panel.Dispose();
				UIElementsRuntimeUtility.RemoveCachedPanelInternal(ownerObject.GetInstanceID());
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00003090 File Offset: 0x00001290
		public static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000309D File Offset: 0x0000129D
		public static void RemoveCachedPanelInternal(int instanceID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000030AA File Offset: 0x000012AA
		public static void RepaintOverlayPanels()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00009450 File Offset: 0x00007650
		public static void UpdateRuntimePanels()
		{
			List<Panel>.Enumerator enumerator = UIElementsRuntimeUtility.GetSortedPlayerPanels().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Panel panel = enumerator.Current;
					BaseRuntimePanel baseRuntimePanel = panel.Cast<BaseRuntimePanel>();
					baseRuntimePanel.Update();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000030B7 File Offset: 0x000012B7
		public static void RegisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.RegisterPlayerloopCallback();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000030C0 File Offset: 0x000012C0
		public static void UnregisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallback();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000030C9 File Offset: 0x000012C9
		public static void SetPanelOrderingDirty()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000030D6 File Offset: 0x000012D6
		public static List<Panel> GetSortedPlayerPanels()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000030E3 File Offset: 0x000012E3
		public static void SortPanels()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001AA RID: 426
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
