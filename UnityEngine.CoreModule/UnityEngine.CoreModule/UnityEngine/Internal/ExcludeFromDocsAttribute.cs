using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Internal
{
	// Token: 0x02000150 RID: 336
	[Serializable]
	public class ExcludeFromDocsAttribute : Attribute
	{
		// Token: 0x060019C2 RID: 6594 RVA: 0x0000D835 File Offset: 0x0000BA35
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromDocsAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Internal", "ExcludeFromDocsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr);
			ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr, 100665690);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00062A7C File Offset: 0x00060C7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromDocsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0000D86E File Offset: 0x0000BA6E
		public ExcludeFromDocsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
