using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000055 RID: 85
	public class UIElementsUtility
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00003165 File Offset: 0x00001365
		public static IMGUIContainer GetCurrentIMGUIContainer()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003172 File Offset: 0x00001372
		public bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000317F File Offset: 0x0000137F
		public bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000094AC File Offset: 0x000076AC
		public bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture()
		{
			return false;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000318C File Offset: 0x0000138C
		public bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00003199 File Offset: 0x00001399
		public bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000031A6 File Offset: 0x000013A6
		public bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000031B3 File Offset: 0x000013B3
		public void UnityEngine.UIElements.IUIElementsUtility.UpdateSchedulers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000094C0 File Offset: 0x000076C0
		public void UnityEngine.UIElements.IUIElementsUtility.RequestRepaintForPanels(Action<ScriptableObject> repaintCallback)
		{
			Dictionary<int, Panel>.Enumerator panelsIterator = UIElementsUtility.GetPanelsIterator();
			while (panelsIterator.MoveNext())
			{
				KeyValuePair<int, Panel> keyValuePair = panelsIterator.Current;
				Panel value = keyValuePair.Value;
				bool flag = value.contextType != ContextType.Editor;
				if (!flag)
				{
					bool isDirty = value.isDirty;
					if (isDirty)
					{
						repaintCallback.Invoke(value.ownerObject);
					}
				}
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000031C0 File Offset: 0x000013C0
		public static void RegisterCachedPanel(int instanceID, Panel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000031CD File Offset: 0x000013CD
		public static void RemoveCachedPanel(int instanceID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000031DA File Offset: 0x000013DA
		public static bool TryGetPanel(int instanceID, out Panel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000031E7 File Offset: 0x000013E7
		public static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000031F4 File Offset: 0x000013F4
		public static void EndContainerGUI(Event evt, Rect layoutSize)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00009524 File Offset: 0x00007724
		public static EventBase CreateEvent(Event systemEvent)
		{
			return UIElementsUtility.CreateEvent(systemEvent, systemEvent.rawType);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00003201 File Offset: 0x00001401
		public static EventBase CreateEvent(Event systemEvent, EventType eventType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000320E File Offset: 0x0000140E
		public static bool DoDispatch(BaseVisualElementPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009544 File Offset: 0x00007744
		public static void GetAllPanels(List<Panel> panels, ContextType contextType)
		{
			Dictionary<int, Panel>.Enumerator panelsIterator = UIElementsUtility.GetPanelsIterator();
			while (panelsIterator.MoveNext())
			{
				KeyValuePair<int, Panel> keyValuePair = panelsIterator.Current;
				bool flag = keyValuePair.Value.contextType == contextType;
				if (flag)
				{
					keyValuePair = panelsIterator.Current;
					panels.Add(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000321B File Offset: 0x0000141B
		public static Dictionary<int, Panel>.Enumerator GetPanelsIterator()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003228 File Offset: 0x00001428
		public static Panel FindOrCreateEditorPanel(ScriptableObject ownerObject)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
