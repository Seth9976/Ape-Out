using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200001A RID: 26
	public static class Strings : Object
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00002607 File Offset: 0x00000807
		// Note: this type is marked as 'beforefieldinit'.
		static Strings()
		{
			Il2CppClassPointerStore<Strings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Strings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Strings>.NativeClassPtr);
			Strings.NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Strings>.NativeClassPtr, 100663559);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007A70 File Offset: 0x00005C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363660, XrefRangeEnd = 363671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtensionNodeMustOverrideProperty(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Strings.NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002640 File Offset: 0x00000840
		public Strings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_String_Object_0;
	}
}
