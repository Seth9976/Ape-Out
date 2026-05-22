using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000B6 RID: 182
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x0600117D RID: 4477 RVA: 0x00048270 File Offset: 0x00046470
		// Note: this type is marked as 'beforefieldinit'.
		static RangeAttribute()
		{
			Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr);
			RangeAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "min");
			RangeAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "max");
			RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, 100664749);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000482DC File Offset: 0x000464DC
		[CallerCount(0)]
		public unsafe RangeAttribute(float min, float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0000A3F8 File Offset: 0x000085F8
		public RangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00048334 File Offset: 0x00046534
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x0000A401 File Offset: 0x00008601
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0004835C File Offset: 0x0004655C
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x0000A41C File Offset: 0x0000861C
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
