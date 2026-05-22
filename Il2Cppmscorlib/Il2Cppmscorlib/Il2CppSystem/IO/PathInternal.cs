using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000215 RID: 533
	public static class PathInternal : Object
	{
		// Token: 0x060022FF RID: 8959 RVA: 0x000C1FF0 File Offset: 0x000C01F0
		// Note: this type is marked as 'beforefieldinit'.
		static PathInternal()
		{
			Il2CppClassPointerStore<PathInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PathInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathInternal>.NativeClassPtr);
			PathInternal.NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100669242);
			PathInternal.NativeMethodInfoPtr_HasIllegalCharacters_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100669243);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000C2048 File Offset: 0x000C0248
		[CallerCount(0)]
		public unsafe static bool IsPartiallyQualified(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000C208C File Offset: 0x000C028C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192051, XrefRangeEnd = 192056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasIllegalCharacters(string path, bool checkAdditional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAdditional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_HasIllegalCharacters_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0000BB76 File Offset: 0x00009D76
		public PathInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_HasIllegalCharacters_Public_Static_Boolean_String_Boolean_0;
	}
}
