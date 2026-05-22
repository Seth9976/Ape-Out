using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200001F RID: 31
	[ObfuscatedName("<PrivateImplementationDetails>")]
	public sealed class _PrivateImplementationDetails_ : Object
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x00004684 File Offset: 0x00002884
		// Note: this type is marked as 'beforefieldinit'.
		static _PrivateImplementationDetails_()
		{
			Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "", "<PrivateImplementationDetails>");
			_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100663880);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00017DA0 File Offset: 0x00015FA0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 117829, RefRangeEnd = 117851, XrefRangeStart = 117829, XrefRangeEnd = 117851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ComputeStringHash(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000046B3 File Offset: 0x000028B3
		public _PrivateImplementationDetails_(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;
	}
}
