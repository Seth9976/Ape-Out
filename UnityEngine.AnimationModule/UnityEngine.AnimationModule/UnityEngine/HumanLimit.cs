using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[StructLayout(2)]
	public struct HumanLimit
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00009AAC File Offset: 0x00007CAC
		// Note: this type is marked as 'beforefieldinit'.
		static HumanLimit()
		{
			Il2CppClassPointerStore<HumanLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr);
			HumanLimit.NativeFieldInfoPtr_m_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Min");
			HumanLimit.NativeFieldInfoPtr_m_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Max");
			HumanLimit.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Center");
			HumanLimit.NativeFieldInfoPtr_m_AxisLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_AxisLength");
			HumanLimit.NativeFieldInfoPtr_m_UseDefaultValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_UseDefaultValues");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000036DF File Offset: 0x000018DF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, ref this));
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00009B40 File Offset: 0x00007D40
		// (set) Token: 0x06000238 RID: 568 RVA: 0x000036F1 File Offset: 0x000018F1
		public bool useDefaultValues
		{
			get
			{
				return this.m_UseDefaultValues != 0;
			}
			set
			{
				this.m_UseDefaultValues = (value ? 1 : 0);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00009B5C File Offset: 0x00007D5C
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00003701 File Offset: 0x00001901
		public Vector3 min
		{
			get
			{
				return this.m_Min;
			}
			set
			{
				this.m_Min = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00009B74 File Offset: 0x00007D74
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000370B File Offset: 0x0000190B
		public Vector3 max
		{
			get
			{
				return this.m_Max;
			}
			set
			{
				this.m_Max = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00009B8C File Offset: 0x00007D8C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00003715 File Offset: 0x00001915
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00009BA4 File Offset: 0x00007DA4
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000371F File Offset: 0x0000191F
		public float axisLength
		{
			get
			{
				return this.m_AxisLength;
			}
			set
			{
				this.m_AxisLength = value;
			}
		}

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_Min;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_Max;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_AxisLength;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_UseDefaultValues;

		// Token: 0x04000164 RID: 356
		[FieldOffset(0)]
		public Vector3 m_Min;

		// Token: 0x04000165 RID: 357
		[FieldOffset(12)]
		public Vector3 m_Max;

		// Token: 0x04000166 RID: 358
		[FieldOffset(24)]
		public Vector3 m_Center;

		// Token: 0x04000167 RID: 359
		[FieldOffset(36)]
		public float m_AxisLength;

		// Token: 0x04000168 RID: 360
		[FieldOffset(40)]
		public int m_UseDefaultValues;
	}
}
