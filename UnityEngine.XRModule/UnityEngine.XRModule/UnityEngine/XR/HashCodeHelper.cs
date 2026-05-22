using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000016 RID: 22
	public static class HashCodeHelper : Object
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00002B76 File Offset: 0x00000D76
		// Note: this type is marked as 'beforefieldinit'.
		static HashCodeHelper()
		{
			Il2CppClassPointerStore<HashCodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "HashCodeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashCodeHelper>.NativeClassPtr);
			HashCodeHelper.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCodeHelper>.NativeClassPtr, 100663342);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000052FC File Offset: 0x000034FC
		[CallerCount(0)]
		public unsafe static int Combine(int hash1, int hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCodeHelper.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002BAF File Offset: 0x00000DAF
		public HashCodeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x040000E8 RID: 232
		public const int k_HashCodeMultiplier = 486187739;
	}
}
