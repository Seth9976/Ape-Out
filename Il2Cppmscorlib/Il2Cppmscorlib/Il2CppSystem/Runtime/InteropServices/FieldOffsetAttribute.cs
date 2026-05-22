using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044F RID: 1103
	public sealed class FieldOffsetAttribute : Attribute
	{
		// Token: 0x060043F7 RID: 17399 RVA: 0x00139AD0 File Offset: 0x00137CD0
		// Note: this type is marked as 'beforefieldinit'.
		static FieldOffsetAttribute()
		{
			Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "FieldOffsetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr);
			FieldOffsetAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr, "_val");
			FieldOffsetAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr, 100673188);
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00139B28 File Offset: 0x00137D28
		[CallerCount(0)]
		public unsafe FieldOffsetAttribute(int offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldOffsetAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00019EC9 File Offset: 0x000180C9
		public FieldOffsetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x00139B70 File Offset: 0x00137D70
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x00019ED2 File Offset: 0x000180D2
		public unsafe int _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldOffsetAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldOffsetAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
