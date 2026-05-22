using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x02000213 RID: 531
	public static class PlatformTools : Object
	{
		// Token: 0x060036FE RID: 14078 RVA: 0x00012ED9 File Offset: 0x000110D9
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformTools()
		{
			Il2CppClassPointerStore<PlatformTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "PlatformTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformTools>.NativeClassPtr);
			PlatformTools.NativeMethodInfoPtr_IsSysVersionInRange_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformTools>.NativeClassPtr, 100676885);
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x0010FD54 File Offset: 0x0010DF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347282, RefRangeEnd = 347283, XrefRangeStart = 347256, XrefRangeEnd = 347282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSysVersionInRange(string min, string max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(min);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(max);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformTools.NativeMethodInfoPtr_IsSysVersionInRange_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00012F12 File Offset: 0x00011112
		public PlatformTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_IsSysVersionInRange_Public_Static_Boolean_String_String_0;
	}
}
