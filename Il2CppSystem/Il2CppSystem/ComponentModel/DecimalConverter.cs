using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000076 RID: 118
	public class DecimalConverter : BaseNumberConverter
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x00005325 File Offset: 0x00003525
		// Note: this type is marked as 'beforefieldinit'.
		static DecimalConverter()
		{
			Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DecimalConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr);
			DecimalConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr, 100664478);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0002F448 File Offset: 0x0002D648
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecimalConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0000535E File Offset: 0x0000355E
		public DecimalConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
