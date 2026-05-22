using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct Long1024
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004464 File Offset: 0x00002664
		// Note: this type is marked as 'beforefieldinit'.
		static Long1024()
		{
			Il2CppClassPointerStore<Long1024>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "Long1024");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Long1024>.NativeClassPtr);
			Long1024.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long1024>.NativeClassPtr, "f0");
			Long1024.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Long1024>.NativeClassPtr, "f1");
			Long1024.NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Long1024>.NativeClassPtr, 100663382);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000044D0 File Offset: 0x000026D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440188, XrefRangeEnd = 440189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref long ElementAt(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Long1024.NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_Int64_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000221C File Offset: 0x0000041C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Long1024>.NativeClassPtr, ref this));
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_f0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_f1;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_Int64_Int32_0;

		// Token: 0x04000054 RID: 84
		[FieldOffset(0)]
		public Long512 f0;

		// Token: 0x04000055 RID: 85
		[FieldOffset(4096)]
		public Long512 f1;
	}
}
