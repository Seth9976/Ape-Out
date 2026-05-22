using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200004A RID: 74
	[StructLayout(2)]
	public struct CullingGroupEvent
	{
		// Token: 0x0600038D RID: 909 RVA: 0x0001E410 File Offset: 0x0001C610
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroupEvent()
		{
			Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroupEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr);
			CullingGroupEvent.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_Index");
			CullingGroupEvent.NativeFieldInfoPtr_m_PrevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_PrevState");
			CullingGroupEvent.NativeFieldInfoPtr_m_ThisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_ThisState");
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00003E65 File Offset: 0x00002065
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0001E47C File Offset: 0x0001C67C
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001E494 File Offset: 0x0001C694
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) > 0;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0001E4B8 File Offset: 0x0001C6B8
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) > 0;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001E4DC File Offset: 0x0001C6DC
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0001E504 File Offset: 0x0001C704
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0001E528 File Offset: 0x0001C728
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0001E544 File Offset: 0x0001C744
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevState;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisState;

		// Token: 0x040002DD RID: 733
		[FieldOffset(0)]
		public int m_Index;

		// Token: 0x040002DE RID: 734
		[FieldOffset(4)]
		public byte m_PrevState;

		// Token: 0x040002DF RID: 735
		[FieldOffset(5)]
		public byte m_ThisState;

		// Token: 0x040002E0 RID: 736
		public const byte kIsVisibleMask = 128;

		// Token: 0x040002E1 RID: 737
		public const byte kDistanceMask = 127;
	}
}
