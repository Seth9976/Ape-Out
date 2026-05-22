using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000036 RID: 54
	public static class PointerCaptureHelper
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00008E18 File Offset: 0x00007018
		public static PointerDispatchState GetStateFor(IEventHandler handler)
		{
			VisualElement visualElement = handler.TryCast<VisualElement>();
			PointerDispatchState pointerDispatchState;
			if (visualElement == null)
			{
				pointerDispatchState = null;
			}
			else
			{
				IPanel panel = visualElement.panel;
				if (panel == null)
				{
					pointerDispatchState = null;
				}
				else
				{
					EventDispatcher dispatcher = panel.dispatcher;
					pointerDispatchState = ((dispatcher != null) ? dispatcher.pointerState : null);
				}
			}
			return pointerDispatchState;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008E58 File Offset: 0x00007058
		public static bool HasPointerCapture(IEventHandler handler, int pointerId)
		{
			PointerDispatchState stateFor = PointerCaptureHelper.GetStateFor(handler);
			return stateFor != null && stateFor.HasPointerCapture(handler, pointerId);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public static void CapturePointer(IEventHandler handler, int pointerId)
		{
			PointerDispatchState stateFor = PointerCaptureHelper.GetStateFor(handler);
			if (stateFor != null)
			{
				stateFor.CapturePointer(handler, pointerId);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002CEE File Offset: 0x00000EEE
		public static void ReleasePointer(IEventHandler handler, int pointerId)
		{
			PointerDispatchState stateFor = PointerCaptureHelper.GetStateFor(handler);
			if (stateFor != null)
			{
				stateFor.ReleasePointer(handler, pointerId);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008E80 File Offset: 0x00007080
		public static IEventHandler GetCapturingElement(IPanel panel, int pointerId)
		{
			IEventHandler eventHandler;
			if (panel == null)
			{
				eventHandler = null;
			}
			else
			{
				EventDispatcher dispatcher = panel.dispatcher;
				eventHandler = ((dispatcher != null) ? dispatcher.pointerState.GetCapturingElement(pointerId) : null);
			}
			return eventHandler;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002D05 File Offset: 0x00000F05
		public static void ReleasePointer(IPanel panel, int pointerId)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.ReleasePointer(pointerId);
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002D25 File Offset: 0x00000F25
		public static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.ActivateCompatibilityMouseEvents(pointerId);
				}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002D45 File Offset: 0x00000F45
		public static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.PreventCompatibilityMouseEvents(pointerId);
				}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008EB0 File Offset: 0x000070B0
		public static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt)
		{
			Nullable<bool> nullable;
			if (panel == null)
			{
				nullable = null;
			}
			else
			{
				EventDispatcher dispatcher = panel.dispatcher;
				nullable = ((dispatcher != null) ? new Nullable<bool>(dispatcher.pointerState.ShouldSendCompatibilityMouseEvents(evt)) : null);
			}
			Nullable<bool> nullable2 = nullable;
			return !nullable2.HasValue || nullable2.GetValueOrDefault();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002D65 File Offset: 0x00000F65
		public static void ProcessPointerCapture(IPanel panel, int pointerId)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.ProcessPointerCapture(pointerId);
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002D85 File Offset: 0x00000F85
		public static void ResetPointerDispatchState(IPanel panel)
		{
			if (panel != null)
			{
				EventDispatcher dispatcher = panel.dispatcher;
				if (dispatcher != null)
				{
					dispatcher.pointerState.Reset();
				}
			}
		}
	}
}
