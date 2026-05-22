using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000003 RID: 3
	public sealed class MaxAttribute : Attribute
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00006090 File Offset: 0x00004290
		// Note: this type is marked as 'beforefieldinit'.
		static MaxAttribute()
		{
			Il2CppClassPointerStore<MaxAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "MaxAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxAttribute>.NativeClassPtr);
			MaxAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxAttribute>.NativeClassPtr, "max");
			MaxAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxAttribute>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000060E8 File Offset: 0x000042E8
		[CallerCount(0)]
		public unsafe MaxAttribute(float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002078 File Offset: 0x00000278
		public MaxAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00006130 File Offset: 0x00004330
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002081 File Offset: 0x00000281
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxAttribute.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxAttribute.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
