using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x000075C8 File Offset: 0x000057C8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorTransitionInfo()
		{
			Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorTransitionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr);
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_FullPath");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_UserName");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Name");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_HasFixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_HasFixedDuration");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Duration");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_NormalizedTime");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_AnyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_AnyState");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_TransitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_TransitionType");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000284D File Offset: 0x00000A4D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007698 File Offset: 0x00005898
		public bool IsName(string name)
		{
			return Animator.StringToHash(name) == this.m_Name || Animator.StringToHash(name) == this.m_FullPath;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000076CC File Offset: 0x000058CC
		public bool IsUserName(string name)
		{
			return Animator.StringToHash(name) == this.m_UserName;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000076EC File Offset: 0x000058EC
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007704 File Offset: 0x00005904
		public int nameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000771C File Offset: 0x0000591C
		public int userNameHash
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00007734 File Offset: 0x00005934
		public DurationUnit durationUnit
		{
			get
			{
				return this.m_HasFixedDuration ? DurationUnit.Fixed : DurationUnit.Normalized;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007754 File Offset: 0x00005954
		public float duration
		{
			get
			{
				return this.m_Duration;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000776C File Offset: 0x0000596C
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00007784 File Offset: 0x00005984
		public bool anyState
		{
			get
			{
				return this.m_AnyState;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000779C File Offset: 0x0000599C
		public bool entry
		{
			get
			{
				return (this.m_TransitionType & 2) != 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000077BC File Offset: 0x000059BC
		public bool exit
		{
			get
			{
				return (this.m_TransitionType & 4) != 0;
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_m_FullPath;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_m_UserName;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFixedDuration;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalizedTime;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_m_AnyState;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_TransitionType;

		// Token: 0x0400009D RID: 157
		[FieldOffset(0)]
		public int m_FullPath;

		// Token: 0x0400009E RID: 158
		[FieldOffset(4)]
		public int m_UserName;

		// Token: 0x0400009F RID: 159
		[FieldOffset(8)]
		public int m_Name;

		// Token: 0x040000A0 RID: 160
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_HasFixedDuration;

		// Token: 0x040000A1 RID: 161
		[FieldOffset(16)]
		public float m_Duration;

		// Token: 0x040000A2 RID: 162
		[FieldOffset(20)]
		public float m_NormalizedTime;

		// Token: 0x040000A3 RID: 163
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool m_AnyState;

		// Token: 0x040000A4 RID: 164
		[FieldOffset(28)]
		public int m_TransitionType;
	}
}
