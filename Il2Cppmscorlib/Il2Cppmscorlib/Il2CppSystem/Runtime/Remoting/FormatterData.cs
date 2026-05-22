using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039A RID: 922
	public class FormatterData : ProviderData
	{
		// Token: 0x06003D0D RID: 15629 RVA: 0x00016D1F File Offset: 0x00014F1F
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterData()
		{
			Il2CppClassPointerStore<FormatterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "FormatterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterData>.NativeClassPtr);
			FormatterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterData>.NativeClassPtr, 100672351);
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00121404 File Offset: 0x0011F604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220313, XrefRangeEnd = 220338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatterData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00016D58 File Offset: 0x00014F58
		public FormatterData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
