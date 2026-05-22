using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DE RID: 222
	[StructLayout(2)]
	public struct RangeInt
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x0004E944 File Offset: 0x0004CB44
		// Note: this type is marked as 'beforefieldinit'.
		static RangeInt()
		{
			Il2CppClassPointerStore<RangeInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeInt>.NativeClassPtr);
			RangeInt.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "start");
			RangeInt.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "length");
			RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100664969);
			RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100664970);
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0004E9C4 File Offset: 0x0004CBC4
		public unsafe int end
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0004E9F4 File Offset: 0x0004CBF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeInt(int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0000ADCE File Offset: 0x00008FCE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, ref this));
		}

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_get_end_Public_get_Int32_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000F62 RID: 3938
		[FieldOffset(0)]
		public int start;

		// Token: 0x04000F63 RID: 3939
		[FieldOffset(4)]
		public int length;
	}
}
