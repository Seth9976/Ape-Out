using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200002D RID: 45
	public static class Misc : Object
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x0001AE18 File Offset: 0x00019018
		// Note: this type is marked as 'beforefieldinit'.
		static Misc()
		{
			Il2CppClassPointerStore<Misc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Misc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Misc>.NativeClassPtr);
			Misc.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Misc>.NativeClassPtr, 100664150);
			Misc.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Misc>.NativeClassPtr, 100664151);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0001AE70 File Offset: 0x00019070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525721, XrefRangeEnd = 525745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Misc.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0001AEA8 File Offset: 0x000190A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525761, RefRangeEnd = 525762, XrefRangeStart = 525745, XrefRangeEnd = 525761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Misc.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00003C61 File Offset: 0x00001E61
		public Misc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;
	}
}
