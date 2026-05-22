using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	public class ExcludeFromObjectFactoryAttribute : Attribute
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x0000AC00 File Offset: 0x00008E00
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromObjectFactoryAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromObjectFactoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr);
			ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr, 100664878);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0004C330 File Offset: 0x0004A530
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromObjectFactoryAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0000AC39 File Offset: 0x00008E39
		public ExcludeFromObjectFactoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
