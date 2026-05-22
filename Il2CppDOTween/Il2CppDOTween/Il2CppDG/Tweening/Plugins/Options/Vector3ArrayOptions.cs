using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000034 RID: 52
	public sealed class Vector3ArrayOptions : ValueType
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00017B48 File Offset: 0x00015D48
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3ArrayOptions()
		{
			Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "Vector3ArrayOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr);
			Vector3ArrayOptions.NativeFieldInfoPtr_axisConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, "axisConstraint");
			Vector3ArrayOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, "snapping");
			Vector3ArrayOptions.NativeFieldInfoPtr_durations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, "durations");
			Vector3ArrayOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr, 100664093);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00017BC8 File Offset: 0x00015DC8
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3ArrayOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002F34 File Offset: 0x00001134
		public Vector3ArrayOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002F3D File Offset: 0x0000113D
		public Vector3ArrayOptions()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3ArrayOptions>.NativeClassPtr))
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00017C00 File Offset: 0x00015E00
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00002F4F File Offset: 0x0000114F
		public unsafe AxisConstraint axisConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_axisConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_axisConstraint)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00017C28 File Offset: 0x00015E28
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002F6A File Offset: 0x0000116A
		public unsafe bool snapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_snapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_snapping)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00017C50 File Offset: 0x00015E50
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002F85 File Offset: 0x00001185
		public unsafe Il2CppStructArray<float> durations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_durations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3ArrayOptions.NativeFieldInfoPtr_durations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_axisConstraint;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_durations;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
