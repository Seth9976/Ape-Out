using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200005F RID: 95
	[StructLayout(2)]
	public struct RenderBuffer
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x00024504 File Offset: 0x00022704
		// Note: this type is marked as 'beforefieldinit'.
		static RenderBuffer()
		{
			Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr);
			RenderBuffer.NativeFieldInfoPtr_m_RenderTextureInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_RenderTextureInstanceID");
			RenderBuffer.NativeFieldInfoPtr_m_BufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_BufferPtr");
			RenderBuffer.SetLoadAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetLoadAction_InjectedDelegate>("UnityEngine.RenderBuffer::SetLoadAction_Injected");
			RenderBuffer.SetStoreAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetStoreAction_InjectedDelegate>("UnityEngine.RenderBuffer::SetStoreAction_Injected");
			RenderBuffer.GetLoadAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetLoadAction_InjectedDelegate>("UnityEngine.RenderBuffer::GetLoadAction_Injected");
			RenderBuffer.GetStoreAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetStoreAction_InjectedDelegate>("UnityEngine.RenderBuffer::GetStoreAction_Injected");
			RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegate>("UnityEngine.RenderBuffer::GetNativeRenderBufferPtr_Injected");
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00004E88 File Offset: 0x00003088
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, ref this));
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00004E9A File Offset: 0x0000309A
		public void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_Injected(ref this, action);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00004EA3 File Offset: 0x000030A3
		public void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_Injected(ref this, action);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00004EAC File Offset: 0x000030AC
		public UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
		{
			return RenderBuffer.GetLoadAction_Injected(ref this);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00004EB4 File Offset: 0x000030B4
		public UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
		{
			return RenderBuffer.GetStoreAction_Injected(ref this);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00004EBC File Offset: 0x000030BC
		public IntPtr GetNativeRenderBufferPtr()
		{
			return RenderBuffer.GetNativeRenderBufferPtr_Injected(ref this);
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x000245A8 File Offset: 0x000227A8
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00004EC4 File Offset: 0x000030C4
		public UnityEngine.Rendering.RenderBufferLoadAction loadAction
		{
			get
			{
				return this.GetLoadAction();
			}
			set
			{
				this.SetLoadAction(value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000245C0 File Offset: 0x000227C0
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00004ECF File Offset: 0x000030CF
		public UnityEngine.Rendering.RenderBufferStoreAction storeAction
		{
			get
			{
				return this.GetStoreAction();
			}
			set
			{
				this.SetStoreAction(value);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00004EDA File Offset: 0x000030DA
		public static void SetLoadAction_Injected(ref RenderBuffer _unity_self, UnityEngine.Rendering.RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_InjectedDelegateField(ref _unity_self, action);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004EE8 File Offset: 0x000030E8
		public static void SetStoreAction_Injected(ref RenderBuffer _unity_self, UnityEngine.Rendering.RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_InjectedDelegateField(ref _unity_self, action);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004EF6 File Offset: 0x000030F6
		public static UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetLoadAction_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00004F03 File Offset: 0x00003103
		public static UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetStoreAction_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00004F10 File Offset: 0x00003110
		public static IntPtr GetNativeRenderBufferPtr_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTextureInstanceID;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPtr;

		// Token: 0x04000448 RID: 1096
		[FieldOffset(0)]
		public int m_RenderTextureInstanceID;

		// Token: 0x04000449 RID: 1097
		[FieldOffset(8)]
		public IntPtr m_BufferPtr;

		// Token: 0x0400044A RID: 1098
		private static readonly RenderBuffer.SetLoadAction_InjectedDelegate SetLoadAction_InjectedDelegateField;

		// Token: 0x0400044B RID: 1099
		private static readonly RenderBuffer.SetStoreAction_InjectedDelegate SetStoreAction_InjectedDelegateField;

		// Token: 0x0400044C RID: 1100
		private static readonly RenderBuffer.GetLoadAction_InjectedDelegate GetLoadAction_InjectedDelegateField;

		// Token: 0x0400044D RID: 1101
		private static readonly RenderBuffer.GetStoreAction_InjectedDelegate GetStoreAction_InjectedDelegateField;

		// Token: 0x0400044E RID: 1102
		private static readonly RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegate GetNativeRenderBufferPtr_InjectedDelegateField;

		// Token: 0x02000440 RID: 1088
		// (Invoke) Token: 0x060026B6 RID: 9910
		private delegate void SetLoadAction_InjectedDelegate(IntPtr _unity_self, UnityEngine.Rendering.RenderBufferLoadAction action);

		// Token: 0x02000441 RID: 1089
		// (Invoke) Token: 0x060026B8 RID: 9912
		private delegate void SetStoreAction_InjectedDelegate(IntPtr _unity_self, UnityEngine.Rendering.RenderBufferStoreAction action);

		// Token: 0x02000442 RID: 1090
		// (Invoke) Token: 0x060026BA RID: 9914
		private delegate UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000443 RID: 1091
		// (Invoke) Token: 0x060026BC RID: 9916
		private delegate UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000444 RID: 1092
		// (Invoke) Token: 0x060026BE RID: 9918
		private delegate IntPtr GetNativeRenderBufferPtr_InjectedDelegate(IntPtr _unity_self);
	}
}
