using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A7 RID: 423
	public static class IntrospectionExtensions : Object
	{
		// Token: 0x06001C0B RID: 7179 RVA: 0x000098B6 File Offset: 0x00007AB6
		// Note: this type is marked as 'beforefieldinit'.
		static IntrospectionExtensions()
		{
			Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "IntrospectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr);
			IntrospectionExtensions.NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr, 100668045);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000A2BA4 File Offset: 0x000A0DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186090, XrefRangeEnd = 186106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInfo GetTypeInfo(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectionExtensions.NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000098EF File Offset: 0x00007AEF
		public IntrospectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0;
	}
}
