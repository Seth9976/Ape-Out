using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x0200011F RID: 287
	public class UnityEventTools : Object
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x0000C8B6 File Offset: 0x0000AAB6
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventTools()
		{
			Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr);
			UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100665462);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 500674, RefRangeEnd = 500679, XrefRangeStart = 500647, XrefRangeEnd = 500674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TidyAssemblyTypeName(string assemblyTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0000C8EF File Offset: 0x0000AAEF
		public UnityEventTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0;
	}
}
