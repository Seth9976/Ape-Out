using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Security;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200045B RID: 1115
	public static class Marshal : Object
	{
		// Token: 0x06004457 RID: 17495 RVA: 0x0013B180 File Offset: 0x00139380
		// Note: this type is marked as 'beforefieldinit'.
		static Marshal()
		{
			Il2CppClassPointerStore<Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "Marshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marshal>.NativeClassPtr);
			Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemMaxDBCSCharSize");
			Marshal.NativeFieldInfoPtr_SystemDefaultCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemDefaultCharSize");
			Marshal.NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673243);
			Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673244);
			Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673245);
			Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673246);
			Marshal.NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673247);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673248);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673249);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673250);
			Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673251);
			Marshal.NativeMethodInfoPtr_DestroyStructure_Public_Static_Void_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673252);
			Marshal.NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673253);
			Marshal.NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673254);
			Marshal.NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673255);
			Marshal.NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673256);
			Marshal.NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673257);
			Marshal.NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673258);
			Marshal.NativeMethodInfoPtr_OffsetOf_Public_Static_IntPtr_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673259);
			Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673260);
			Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673261);
			Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673262);
			Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673263);
			Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673264);
			Marshal.NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673265);
			Marshal.NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673266);
			Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673267);
			Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673268);
			Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673269);
			Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673270);
			Marshal.NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673271);
			Marshal.NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673272);
			Marshal.NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673273);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673274);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673275);
			Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673276);
			Marshal.NativeMethodInfoPtr_SecureStringToCoTaskMemUnicode_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673277);
			Marshal.NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673278);
			Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673279);
			Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673280);
			Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673281);
			Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673282);
			Marshal.NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673283);
			Marshal.NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673284);
			Marshal.NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673285);
			Marshal.NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673286);
			Marshal.NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673287);
			Marshal.NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673288);
			Marshal.NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673289);
			Marshal.NativeMethodInfoPtr_WriteIntPtr_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673290);
			Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673291);
			Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673292);
			Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673293);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673294);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673295);
			Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100673296);
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x0013B610 File Offset: 0x00139810
		[CallerCount(0)]
		public unsafe static IntPtr AllocCoTaskMem(int cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x0013B650 File Offset: 0x00139850
		[CallerCount(0)]
		public unsafe static IntPtr AllocHGlobal(IntPtr cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x0013B690 File Offset: 0x00139890
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 227683, RefRangeEnd = 227698, XrefRangeStart = 227680, XrefRangeEnd = 227683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocHGlobal(int cb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x0013B6D0 File Offset: 0x001398D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227698, XrefRangeEnd = 227699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x0013B730 File Offset: 0x00139930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227699, XrefRangeEnd = 227700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x0013B790 File Offset: 0x00139990
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 227704, RefRangeEnd = 227709, XrefRangeStart = 227700, XrefRangeEnd = 227704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<byte> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x0013B7F0 File Offset: 0x001399F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227709, XrefRangeEnd = 227713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppStructArray<IntPtr> source, int startIndex, IntPtr destination, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x0013B850 File Offset: 0x00139A50
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 227717, RefRangeEnd = 227731, XrefRangeStart = 227713, XrefRangeEnd = 227717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<byte> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x0013B8B0 File Offset: 0x00139AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227735, RefRangeEnd = 227737, XrefRangeStart = 227731, XrefRangeEnd = 227735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(IntPtr source, Il2CppStructArray<char> destination, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x0013B910 File Offset: 0x00139B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227738, RefRangeEnd = 227740, XrefRangeStart = 227737, XrefRangeEnd = 227738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyStructure(IntPtr ptr, Type structuretype)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(structuretype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_DestroyStructure_Public_Static_Void_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x0013B954 File Offset: 0x00139B54
		[CallerCount(0)]
		public unsafe static void FreeBSTR(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x0013B988 File Offset: 0x00139B88
		[CallerCount(0)]
		public unsafe static void FreeHGlobal(IntPtr hglobal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hglobal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x0013B9BC File Offset: 0x00139BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227740, XrefRangeEnd = 227751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearUnicode(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x0013B9F0 File Offset: 0x00139BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227751, XrefRangeEnd = 227768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x0013BA24 File Offset: 0x00139C24
		[CallerCount(0)]
		public unsafe static int GetHRForException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x0013BA68 File Offset: 0x00139C68
		[CallerCount(0)]
		public unsafe static int GetLastWin32Error()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x0013BA98 File Offset: 0x00139C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227768, XrefRangeEnd = 227769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr OffsetOf(Type t, string fieldName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_OffsetOf_Public_Static_IntPtr_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x0013BAEC File Offset: 0x00139CEC
		[CallerCount(0)]
		public unsafe static string PtrToStringAnsi(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x0013BB24 File Offset: 0x00139D24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 227769, RefRangeEnd = 227774, XrefRangeStart = 227769, XrefRangeEnd = 227769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringUni(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x0013BB5C File Offset: 0x00139D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227776, RefRangeEnd = 227777, XrefRangeStart = 227774, XrefRangeEnd = 227776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringUni(IntPtr ptr, int len)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x0013BBA4 File Offset: 0x00139DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227777, XrefRangeEnd = 227778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PtrToStructure(IntPtr ptr, Type structureType)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(structureType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x0013BBF8 File Offset: 0x00139DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227778, XrefRangeEnd = 227787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T PtrToStructure<T>(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x0013BC34 File Offset: 0x00139E34
		[CallerCount(0)]
		public unsafe static byte ReadByte(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x0013BC80 File Offset: 0x00139E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227787, XrefRangeEnd = 227788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ReadInt16(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x0013BCCC File Offset: 0x00139ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227788, XrefRangeEnd = 227789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadInt32(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x0013BD0C File Offset: 0x00139F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227789, XrefRangeEnd = 227790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadInt32(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x0013BD58 File Offset: 0x00139F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227790, XrefRangeEnd = 227791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ReadInt64(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x0013BD98 File Offset: 0x00139F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227791, XrefRangeEnd = 227792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ReadInt64(IntPtr ptr, int ofs)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x0013BDE4 File Offset: 0x00139FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227792, XrefRangeEnd = 227796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ReadIntPtr(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x0013BE24 File Offset: 0x0013A024
		[CallerCount(0)]
		public unsafe static int ReleaseInternal(IntPtr pUnk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pUnk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x0013BE64 File Offset: 0x0013A064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227807, RefRangeEnd = 227809, XrefRangeStart = 227796, XrefRangeEnd = 227807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Release(IntPtr pUnk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pUnk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x0013BEA4 File Offset: 0x0013A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227809, XrefRangeEnd = 227815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf(Object structure)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(structure);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x0013BEE8 File Offset: 0x0013A0E8
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 227816, RefRangeEnd = 227872, XrefRangeStart = 227815, XrefRangeEnd = 227816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x0013BF2C File Offset: 0x0013A12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227872, XrefRangeEnd = 227906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf<T>(T structure)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = structure;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref structure;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x0013BFB8 File Offset: 0x0013A1B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227921, RefRangeEnd = 227923, XrefRangeStart = 227906, XrefRangeEnd = 227921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToCoTaskMemUnicode_Public_Static_IntPtr_SecureString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x0013BFFC File Offset: 0x0013A1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227923, XrefRangeEnd = 227933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x0013C040 File Offset: 0x0013A240
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 227940, RefRangeEnd = 227948, XrefRangeStart = 227933, XrefRangeEnd = 227940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StructureToPtr(Object structure, IntPtr ptr, bool fDeleteOld)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(structure);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fDeleteOld;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x0013C094 File Offset: 0x0013A294
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 227958, RefRangeEnd = 227966, XrefRangeStart = 227948, XrefRangeEnd = 227958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr3 = ptr2;
				ref T ptr5;
				if (!typeof(T).IsValueType)
				{
					T t = structure;
					if (!(t is string))
					{
						ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr4) != null)
						{
							ptr5 = ref ptr4;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
							{
								ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
							}
						}
					}
					else
					{
						ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr5 = ref structure;
				}
				*ptr3 = ref ptr5;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fDeleteOld;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x0013C134 File Offset: 0x0013A334
		[CallerCount(0)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x0013C184 File Offset: 0x0013A384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227966, XrefRangeEnd = 227969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr UnsafeAddrOfPinnedArrayElement<T>(Il2CppArrayBase<T> arr, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x0013C1D4 File Offset: 0x0013A3D4
		[CallerCount(0)]
		public unsafe static void WriteByte(IntPtr ptr, byte val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Byte_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x0013C214 File Offset: 0x0013A414
		[CallerCount(0)]
		public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Int32_Byte_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x0013C264 File Offset: 0x0013A464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227969, XrefRangeEnd = 227970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x0013C2B4 File Offset: 0x0013A4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227970, XrefRangeEnd = 227971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt32(IntPtr ptr, int val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x0013C2F4 File Offset: 0x0013A4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227971, XrefRangeEnd = 227972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt32(IntPtr ptr, int ofs, int val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x0013C344 File Offset: 0x0013A544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227972, XrefRangeEnd = 227973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt64(IntPtr ptr, long val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x0013C384 File Offset: 0x0013A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227973, XrefRangeEnd = 227974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt64(IntPtr ptr, int ofs, long val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ofs;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int32_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x0013C3D4 File Offset: 0x0013A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227974, XrefRangeEnd = 227978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteIntPtr(IntPtr ptr, IntPtr val)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_WriteIntPtr_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x0013C414 File Offset: 0x0013A614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227978, XrefRangeEnd = 227980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x0013C468 File Offset: 0x0013A668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228023, RefRangeEnd = 228024, XrefRangeStart = 227980, XrefRangeEnd = 228023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x0013C4BC File Offset: 0x0013A6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228024, XrefRangeEnd = 228033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0<TDelegate>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr, false, true);
			}
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x0013C4F8 File Offset: 0x0013A6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228033, XrefRangeEnd = 228034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x0013C53C File Offset: 0x0013A73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228047, RefRangeEnd = 228048, XrefRangeStart = 228034, XrefRangeEnd = 228047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegate(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x0013C580 File Offset: 0x0013A780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228048, XrefRangeEnd = 228062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TDelegate ptr4;
				if (!typeof(TDelegate).IsValueType)
				{
					TDelegate tdelegate = d;
					if (!(tdelegate is string))
					{
						ref TDelegate ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tdelegate as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tdelegate as string);
					}
				}
				else
				{
					ptr4 = ref d;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marshal.MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x0001A086 File Offset: 0x00018286
		public Marshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x0013C60C File Offset: 0x0013A80C
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x0001A08F File Offset: 0x0001828F
		public unsafe static int SystemMaxDBCSCharSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&value));
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x0013C628 File Offset: 0x0013A828
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x0001A09D File Offset: 0x0001829D
		public unsafe static int SystemDefaultCharSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Marshal.NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marshal.NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&value));
			}
		}

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeFieldInfoPtr_SystemMaxDBCSCharSize;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeFieldInfoPtr_SystemDefaultCharSize;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStructure_Public_Static_Void_IntPtr_Type_0;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_OffsetOf_Public_Static_IntPtr_Type_String_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_Int32_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0;

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_0;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Static_Int32_IntPtr_Int32_0;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_0;

		// Token: 0x040037DF RID: 14303
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Static_Int64_IntPtr_Int32_0;

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntPtr_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x040037E1 RID: 14305
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0;

		// Token: 0x040037E2 RID: 14306
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0;

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Object_0;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_T_0;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToCoTaskMemUnicode_Public_Static_IntPtr_SecureString_0;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0;

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0;

		// Token: 0x040037EA RID: 14314
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0;

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Byte_0;

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Static_Void_IntPtr_Int32_Byte_0;

		// Token: 0x040037EE RID: 14318
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0;

		// Token: 0x040037EF RID: 14319
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_0;

		// Token: 0x040037F0 RID: 14320
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32_Public_Static_Void_IntPtr_Int32_Int32_0;

		// Token: 0x040037F1 RID: 14321
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int64_0;

		// Token: 0x040037F2 RID: 14322
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt64_Public_Static_Void_IntPtr_Int32_Int64_0;

		// Token: 0x040037F3 RID: 14323
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntPtr_Public_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x040037F4 RID: 14324
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0;

		// Token: 0x040037F5 RID: 14325
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0;

		// Token: 0x040037F6 RID: 14326
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0;

		// Token: 0x040037F7 RID: 14327
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0;

		// Token: 0x040037F8 RID: 14328
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0;

		// Token: 0x040037F9 RID: 14329
		private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0;

		// Token: 0x02000649 RID: 1609
		private sealed class MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>
		{
			// Token: 0x04004596 RID: 17814
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064A RID: 1610
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_T_0<T>
		{
			// Token: 0x04004597 RID: 17815
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_T_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064B RID: 1611
		private sealed class MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>
		{
			// Token: 0x04004598 RID: 17816
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064C RID: 1612
		private sealed class MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004599 RID: 17817
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064D RID: 1613
		private sealed class MethodInfoStoreGeneric_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0<TDelegate>
		{
			// Token: 0x0400459A RID: 17818
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
		}

		// Token: 0x0200064E RID: 1614
		private sealed class MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>
		{
			// Token: 0x0400459B RID: 17819
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Marshal.NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
		}
	}
}
