using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct AnimatorStateInfo
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00007384 File Offset: 0x00005584
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorStateInfo()
		{
			Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorStateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr);
			AnimatorStateInfo.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Name");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Path");
			AnimatorStateInfo.NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_FullPath");
			AnimatorStateInfo.NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_NormalizedTime");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Length");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Speed");
			AnimatorStateInfo.NativeFieldInfoPtr_m_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_SpeedMultiplier");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Tag");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Loop");
			AnimatorStateInfo.NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663333);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000747C File Offset: 0x0000567C
		public unsafe int fullPathHash
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorStateInfo.NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000283B File Offset: 0x00000A3B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000074AC File Offset: 0x000056AC
		public bool IsName(string name)
		{
			int num = Animator.StringToHash(name);
			return num == this.m_FullPath || num == this.m_Name || num == this.m_Path;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000074E4 File Offset: 0x000056E4
		public int nameHash
		{
			get
			{
				return this.m_Path;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000074FC File Offset: 0x000056FC
		public int shortNameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00007514 File Offset: 0x00005714
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000752C File Offset: 0x0000572C
		public float length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00007544 File Offset: 0x00005744
		public float speed
		{
			get
			{
				return this.m_Speed;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000755C File Offset: 0x0000575C
		public float speedMultiplier
		{
			get
			{
				return this.m_SpeedMultiplier;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00007574 File Offset: 0x00005774
		public int tagHash
		{
			get
			{
				return this.m_Tag;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000758C File Offset: 0x0000578C
		public bool IsTag(string tag)
		{
			return Animator.StringToHash(tag) == this.m_Tag;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000075AC File Offset: 0x000057AC
		public bool loop
		{
			get
			{
				return this.m_Loop != 0;
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_m_FullPath;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalizedTime;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_m_Speed;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_m_SpeedMultiplier;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_m_Tag;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0;

		// Token: 0x0400008C RID: 140
		[FieldOffset(0)]
		public int m_Name;

		// Token: 0x0400008D RID: 141
		[FieldOffset(4)]
		public int m_Path;

		// Token: 0x0400008E RID: 142
		[FieldOffset(8)]
		public int m_FullPath;

		// Token: 0x0400008F RID: 143
		[FieldOffset(12)]
		public float m_NormalizedTime;

		// Token: 0x04000090 RID: 144
		[FieldOffset(16)]
		public float m_Length;

		// Token: 0x04000091 RID: 145
		[FieldOffset(20)]
		public float m_Speed;

		// Token: 0x04000092 RID: 146
		[FieldOffset(24)]
		public float m_SpeedMultiplier;

		// Token: 0x04000093 RID: 147
		[FieldOffset(28)]
		public int m_Tag;

		// Token: 0x04000094 RID: 148
		[FieldOffset(32)]
		public int m_Loop;
	}
}
