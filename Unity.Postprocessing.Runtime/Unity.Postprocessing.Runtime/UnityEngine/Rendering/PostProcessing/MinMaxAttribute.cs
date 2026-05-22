using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000005 RID: 5
	public sealed class MinMaxAttribute : Attribute
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00006220 File Offset: 0x00004420
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxAttribute()
		{
			Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "MinMaxAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr);
			MinMaxAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr, "min");
			MinMaxAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr, "max");
			MinMaxAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000628C File Offset: 0x0000448C
		[CallerCount(0)]
		public unsafe MinMaxAttribute(float min, float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020C0 File Offset: 0x000002C0
		public MinMaxAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000062E4 File Offset: 0x000044E4
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020C9 File Offset: 0x000002C9
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000630C File Offset: 0x0000450C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000020E4 File Offset: 0x000002E4
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
