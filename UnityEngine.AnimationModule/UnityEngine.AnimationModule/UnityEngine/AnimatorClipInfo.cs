using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct AnimatorClipInfo
	{
		// Token: 0x060000BF RID: 191 RVA: 0x000072B4 File Offset: 0x000054B4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorClipInfo()
		{
			Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorClipInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr);
			AnimatorClipInfo.NativeFieldInfoPtr_m_ClipInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_ClipInstanceID");
			AnimatorClipInfo.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_Weight");
			AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegateField = IL2CPP.ResolveICall<AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegate>("UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002829 File Offset: 0x00000A29
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000731C File Offset: 0x0000551C
		public AnimationClip clip
		{
			get
			{
				return (this.m_ClipInstanceID != 0) ? AnimatorClipInfo.InstanceIDToAnimationClipPPtr(this.m_ClipInstanceID) : null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00007344 File Offset: 0x00005544
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000735C File Offset: 0x0000555C
		public static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID)
		{
			IntPtr intPtr = AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipInstanceID;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x0400007F RID: 127
		[FieldOffset(0)]
		public int m_ClipInstanceID;

		// Token: 0x04000080 RID: 128
		[FieldOffset(4)]
		public float m_Weight;

		// Token: 0x04000081 RID: 129
		private static readonly AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegate InstanceIDToAnimationClipPPtrDelegateField;

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate IntPtr InstanceIDToAnimationClipPPtrDelegate(int instanceID);
	}
}
