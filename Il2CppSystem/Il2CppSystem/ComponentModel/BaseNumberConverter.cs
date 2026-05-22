using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200009A RID: 154
	public class BaseNumberConverter : TypeConverter
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00005AE4 File Offset: 0x00003CE4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseNumberConverter()
		{
			Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BaseNumberConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr);
			BaseNumberConverter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr, 100664588);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00032724 File Offset: 0x00030924
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseNumberConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseNumberConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseNumberConverter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005B1D File Offset: 0x00003D1D
		public BaseNumberConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
