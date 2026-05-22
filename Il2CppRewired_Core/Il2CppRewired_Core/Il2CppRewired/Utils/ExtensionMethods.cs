using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001D9 RID: 473
	public static class ExtensionMethods : Object
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x0001189A File Offset: 0x0000FA9A
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionMethods()
		{
			Il2CppClassPointerStore<ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "ExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionMethods>.NativeClassPtr);
			ExtensionMethods.NativeMethodInfoPtr_IsNullOrDestroyed_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethods>.NativeClassPtr, 100675748);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000F30C4 File Offset: 0x000F12C4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 335713, RefRangeEnd = 335727, XrefRangeStart = 335712, XrefRangeEnd = 335713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrDestroyed(this Object @object)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethods.NativeMethodInfoPtr_IsNullOrDestroyed_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000118D3 File Offset: 0x0000FAD3
		public ExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrDestroyed_Public_Static_Boolean_Object_0;
	}
}
