using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000091 RID: 145
	[Serializable]
	public class ContextStaticAttribute : Attribute
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00004946 File Offset: 0x00002B46
		// Note: this type is marked as 'beforefieldinit'.
		static ContextStaticAttribute()
		{
			Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ContextStaticAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr);
			ContextStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr, 100664703);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0004A8CC File Offset: 0x00048ACC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextStaticAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0000497F File Offset: 0x00002B7F
		public ContextStaticAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
