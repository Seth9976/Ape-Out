using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000167 RID: 359
	public class MiscFacetsChecker : FacetsChecker
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x0000B4D1 File Offset: 0x000096D1
		// Note: this type is marked as 'beforefieldinit'.
		static MiscFacetsChecker()
		{
			Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "MiscFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr);
			MiscFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr, 100667244);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00083928 File Offset: 0x00081B28
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MiscFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0000B50A File Offset: 0x0000970A
		public MiscFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
