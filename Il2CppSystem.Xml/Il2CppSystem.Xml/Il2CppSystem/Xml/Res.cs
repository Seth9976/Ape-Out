using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000B1 RID: 177
	public static class Res : Object
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x0005C754 File Offset: 0x0005A954
		// Note: this type is marked as 'beforefieldinit'.
		static Res()
		{
			Il2CppClassPointerStore<Res>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Res");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Res>.NativeClassPtr);
			Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Res>.NativeClassPtr, 100665964);
			Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Res>.NativeClassPtr, 100665965);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0005C7AC File Offset: 0x0005A9AC
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 403214, RefRangeEnd = 403257, XrefRangeStart = 403205, XrefRangeEnd = 403214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0000777B File Offset: 0x0000597B
		public static string GetString(string name, params Object[] args)
		{
			return Res.GetString(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00007789 File Offset: 0x00005989
		public Res(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
	}
}
