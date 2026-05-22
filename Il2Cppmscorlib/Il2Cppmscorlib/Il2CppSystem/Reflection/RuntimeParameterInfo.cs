using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DE RID: 478
	public class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x06001F05 RID: 7941 RVA: 0x0000A7AB File Offset: 0x000089AB
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeParameterInfo()
		{
			Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeParameterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr);
			RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100668505);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x000AFAD0 File Offset: 0x000ADCD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeParameterInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0000A7E4 File Offset: 0x000089E4
		public RuntimeParameterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
