using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DC RID: 988
	public sealed class SoapParameterAttribute : SoapAttribute
	{
		// Token: 0x06003FBA RID: 16314 RVA: 0x00017DA3 File Offset: 0x00015FA3
		// Note: this type is marked as 'beforefieldinit'.
		static SoapParameterAttribute()
		{
			Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapParameterAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr);
			SoapParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr, 100672698);
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x0012B23C File Offset: 0x0012943C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapParameterAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapParameterAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapParameterAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00017DDC File Offset: 0x00015FDC
		public SoapParameterAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003465 RID: 13413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
