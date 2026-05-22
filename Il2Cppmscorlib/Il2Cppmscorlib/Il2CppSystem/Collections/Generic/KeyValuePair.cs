using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048D RID: 1165
	public static class KeyValuePair : Object
	{
		// Token: 0x0600471F RID: 18207 RVA: 0x0001AD8E File Offset: 0x00018F8E
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePair()
		{
			Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyValuePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr);
			KeyValuePair.NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr, 100673874);
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00147C68 File Offset: 0x00145E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230489, RefRangeEnd = 230491, XrefRangeStart = 230480, XrefRangeEnd = 230489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PairToString(Object key, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair.NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x0001ADC7 File Offset: 0x00018FC7
		public KeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040039CE RID: 14798
		private static readonly IntPtr NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0;
	}
}
