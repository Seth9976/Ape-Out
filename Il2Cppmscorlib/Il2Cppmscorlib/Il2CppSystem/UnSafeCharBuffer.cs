using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000103 RID: 259
	[StructLayout(2)]
	public struct UnSafeCharBuffer
	{
		// Token: 0x0600130E RID: 4878 RVA: 0x0007CD1C File Offset: 0x0007AF1C
		// Note: this type is marked as 'beforefieldinit'.
		static UnSafeCharBuffer()
		{
			Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnSafeCharBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr);
			UnSafeCharBuffer.NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, "m_buffer");
			UnSafeCharBuffer.NativeFieldInfoPtr_m_totalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, "m_totalSize");
			UnSafeCharBuffer.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, "m_length");
			UnSafeCharBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, 100666668);
			UnSafeCharBuffer.NativeMethodInfoPtr_AppendString_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, 100666669);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0007CDB0 File Offset: 0x0007AFB0
		[CallerCount(0)]
		public unsafe UnSafeCharBuffer(char* buffer, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnSafeCharBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0007CDF0 File Offset: 0x0007AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173333, XrefRangeEnd = 173334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendString(string stringToAppend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToAppend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnSafeCharBuffer.NativeMethodInfoPtr_AppendString_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00006751 File Offset: 0x00004951
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, ref this));
		}

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_m_buffer;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_m_totalSize;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_AppendString_Public_Void_String_0;

		// Token: 0x04001090 RID: 4240
		[FieldOffset(0)]
		public IntPtr m_buffer;

		// Token: 0x04001091 RID: 4241
		[FieldOffset(8)]
		public int m_totalSize;

		// Token: 0x04001092 RID: 4242
		[FieldOffset(12)]
		public int m_length;
	}
}
