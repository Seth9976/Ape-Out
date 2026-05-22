using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000005 RID: 5
	public class CreatePropertyAttribute : Attribute
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002131 File Offset: 0x00000331
		// Note: this type is marked as 'beforefieldinit'.
		static CreatePropertyAttribute()
		{
			Il2CppClassPointerStore<CreatePropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "CreatePropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatePropertyAttribute>.NativeClassPtr);
			CreatePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatePropertyAttribute>.NativeClassPtr, 100663374);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003EC8 File Offset: 0x000020C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatePropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatePropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000216A File Offset: 0x0000036A
		public CreatePropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
