using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000007 RID: 7
	public sealed class TrackballAttribute : Attribute
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000065A8 File Offset: 0x000047A8
		// Note: this type is marked as 'beforefieldinit'.
		static TrackballAttribute()
		{
			Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TrackballAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr);
			TrackballAttribute.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr, "mode");
			TrackballAttribute.NativeMethodInfoPtr__ctor_Public_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006600 File Offset: 0x00004800
		[CallerCount(0)]
		public unsafe TrackballAttribute(TrackballAttribute.Mode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackballAttribute.NativeMethodInfoPtr__ctor_Public_Void_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002197 File Offset: 0x00000397
		public TrackballAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00006648 File Offset: 0x00004848
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000021A0 File Offset: 0x000003A0
		public unsafe TrackballAttribute.Mode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackballAttribute.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackballAttribute.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mode_0;

		// Token: 0x02000068 RID: 104
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x04000465 RID: 1125
			None,
			// Token: 0x04000466 RID: 1126
			Lift,
			// Token: 0x04000467 RID: 1127
			Gamma,
			// Token: 0x04000468 RID: 1128
			Gain
		}
	}
}
