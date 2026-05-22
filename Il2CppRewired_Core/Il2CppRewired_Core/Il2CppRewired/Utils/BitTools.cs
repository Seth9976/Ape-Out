using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001EC RID: 492
	public static class BitTools : Object
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x000F9688 File Offset: 0x000F7888
		// Note: this type is marked as 'beforefieldinit'.
		static BitTools()
		{
			Il2CppClassPointerStore<BitTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "BitTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitTools>.NativeClassPtr);
			BitTools.NativeFieldInfoPtr_IGIqzuMEMFRJldZXfqQXjZlHwWw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitTools>.NativeClassPtr, "IGIqzuMEMFRJldZXfqQXjZlHwWw");
			BitTools.NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int16_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitTools>.NativeClassPtr, 100675974);
			BitTools.NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitTools>.NativeClassPtr, 100675975);
			BitTools.NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int64_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitTools>.NativeClassPtr, 100675976);
			BitTools.NativeMethodInfoPtr_get_intToFloatBuffer_Private_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitTools>.NativeClassPtr, 100675977);
			BitTools.NativeMethodInfoPtr_IntToFloat_Public_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitTools>.NativeClassPtr, 100675978);
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000F9730 File Offset: 0x000F7930
		[CallerCount(0)]
		public unsafe static void GetBytes(short value, Il2CppStructArray<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitTools.NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int16_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x000F9774 File Offset: 0x000F7974
		[CallerCount(0)]
		public unsafe static void GetBytes(int value, Il2CppStructArray<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitTools.NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x000F97B8 File Offset: 0x000F79B8
		[CallerCount(0)]
		public unsafe static void GetBytes(long value, Il2CppStructArray<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitTools.NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int64_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x000F97FC File Offset: 0x000F79FC
		public unsafe static Il2CppStructArray<byte> intToFloatBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337847, XrefRangeEnd = 337853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitTools.NativeMethodInfoPtr_get_intToFloatBuffer_Private_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000F9830 File Offset: 0x000F7A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337853, XrefRangeEnd = 337874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float IntToFloat(IntPtr pointer, int offset = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitTools.NativeMethodInfoPtr_IntToFloat_Public_Static_Single_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00011CE1 File Offset: 0x0000FEE1
		public BitTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000F987C File Offset: 0x000F7A7C
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x00011CEA File Offset: 0x0000FEEA
		public unsafe static Il2CppStructArray<byte> IGIqzuMEMFRJldZXfqQXjZlHwWw
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BitTools.NativeFieldInfoPtr_IGIqzuMEMFRJldZXfqQXjZlHwWw, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BitTools.NativeFieldInfoPtr_IGIqzuMEMFRJldZXfqQXjZlHwWw, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeFieldInfoPtr_IGIqzuMEMFRJldZXfqQXjZlHwWw;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int16_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Void_Int64_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeMethodInfoPtr_get_intToFloatBuffer_Private_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeMethodInfoPtr_IntToFloat_Public_Static_Single_IntPtr_Int32_0;
	}
}
