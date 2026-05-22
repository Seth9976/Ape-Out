using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200005F RID: 95
	[StructLayout(2)]
	public struct SAqoCegcvKgFgjflCdHMSkxUWCZ
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x00027D00 File Offset: 0x00025F00
		// Note: this type is marked as 'beforefieldinit'.
		static SAqoCegcvKgFgjflCdHMSkxUWCZ()
		{
			Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "SAqoCegcvKgFgjflCdHMSkxUWCZ");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr);
			SAqoCegcvKgFgjflCdHMSkxUWCZ.NativeFieldInfoPtr_HACQmcjqhgCYsxTyKixwxBzmzcb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr, "HACQmcjqhgCYsxTyKixwxBzmzcb");
			SAqoCegcvKgFgjflCdHMSkxUWCZ.NativeFieldInfoPtr_KeiUjnxxwkjDHFqCUDxsuCsYgYc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr, "KeiUjnxxwkjDHFqCUDxsuCsYgYc");
			SAqoCegcvKgFgjflCdHMSkxUWCZ.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr, 100664720);
			SAqoCegcvKgFgjflCdHMSkxUWCZ.NativeMethodInfoPtr_qslMxoVCbxcYgsUGtHybwQJPIfY_Internal_Void_byref_GFkUdsWyTmBTmquJwdfcfvqwicu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr, 100664721);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00027D80 File Offset: 0x00025F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SAqoCegcvKgFgjflCdHMSkxUWCZ(int minimum, int maximum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SAqoCegcvKgFgjflCdHMSkxUWCZ.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00027DC0 File Offset: 0x00025FC0
		[CallerCount(0)]
		public unsafe void qslMxoVCbxcYgsUGtHybwQJPIfY(ref GFkUdsWyTmBTmquJwdfcfvqwicu A_1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SAqoCegcvKgFgjflCdHMSkxUWCZ.NativeMethodInfoPtr_qslMxoVCbxcYgsUGtHybwQJPIfY_Internal_Void_byref_GFkUdsWyTmBTmquJwdfcfvqwicu_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00005996 File Offset: 0x00003B96
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SAqoCegcvKgFgjflCdHMSkxUWCZ>.NativeClassPtr, ref this));
		}

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_HACQmcjqhgCYsxTyKixwxBzmzcb;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_KeiUjnxxwkjDHFqCUDxsuCsYgYc;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_qslMxoVCbxcYgsUGtHybwQJPIfY_Internal_Void_byref_GFkUdsWyTmBTmquJwdfcfvqwicu_0;

		// Token: 0x040006DE RID: 1758
		[FieldOffset(0)]
		public int HACQmcjqhgCYsxTyKixwxBzmzcb;

		// Token: 0x040006DF RID: 1759
		[FieldOffset(4)]
		public int KeiUjnxxwkjDHFqCUDxsuCsYgYc;
	}
}
