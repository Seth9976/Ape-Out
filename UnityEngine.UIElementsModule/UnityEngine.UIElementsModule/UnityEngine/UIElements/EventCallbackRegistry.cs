using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C4 RID: 196
	public class EventCallbackRegistry
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x0000576F File Offset: 0x0000396F
		public static EventCallbackList GetCallbackList([Optional] EventCallbackList initializer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000577C File Offset: 0x0000397C
		public static void ReleaseCallbackList(EventCallbackList toRelease)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00005789 File Offset: 0x00003989
		public EventCallbackList GetCallbackListForWriting()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00005796 File Offset: 0x00003996
		public EventCallbackList GetCallbackListForReading()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000BB18 File Offset: 0x00009D18
		public bool ShouldRegisterCallback(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			bool flag = callback == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				EventCallbackList callbackListForReading = this.GetCallbackListForReading();
				bool flag3 = callbackListForReading != null;
				flag2 = !flag3 || !callbackListForReading.Contains(eventTypeId, callback, phase);
			}
			return flag2;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000BB58 File Offset: 0x00009D58
		public bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown)
		{
			bool flag = callback == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				EventCallbackList callbackListForWriting = this.GetCallbackListForWriting();
				CallbackPhase callbackPhase = ((useTrickleDown == TrickleDown.TrickleDown) ? CallbackPhase.TrickleDownAndTarget : CallbackPhase.TargetAndBubbleUp);
				flag2 = callbackListForWriting.Remove(eventTypeId, callback, callbackPhase);
			}
			return flag2;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000057A3 File Offset: 0x000039A3
		public void InvokeCallbacks(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000057B0 File Offset: 0x000039B0
		public bool HasTrickleDownHandlers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000057BD File Offset: 0x000039BD
		public bool HasBubbleHandlers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
