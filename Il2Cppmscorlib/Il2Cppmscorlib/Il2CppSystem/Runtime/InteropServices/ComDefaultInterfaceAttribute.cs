using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000440 RID: 1088
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		// Token: 0x060043B5 RID: 17333 RVA: 0x001390E4 File Offset: 0x001372E4
		// Note: this type is marked as 'beforefieldinit'.
		static ComDefaultInterfaceAttribute()
		{
			Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComDefaultInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr);
			ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, "_val");
			ComDefaultInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, 100673172);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0013913C File Offset: 0x0013733C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComDefaultInterfaceAttribute(Type defaultInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComDefaultInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00019BBF File Offset: 0x00017DBF
		public ComDefaultInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x00139188 File Offset: 0x00137388
		// (set) Token: 0x060043B9 RID: 17337 RVA: 0x00019BC8 File Offset: 0x00017DC8
		public unsafe Type _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
