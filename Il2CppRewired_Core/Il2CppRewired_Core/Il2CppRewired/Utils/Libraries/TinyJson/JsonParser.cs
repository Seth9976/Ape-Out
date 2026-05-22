using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppRewired.Utils.Libraries.TinyJson
{
	// Token: 0x020001DD RID: 477
	public static class JsonParser : Object
	{
		// Token: 0x060030E9 RID: 12521 RVA: 0x000F328C File Offset: 0x000F148C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonParser()
		{
			Il2CppClassPointerStore<JsonParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Libraries.TinyJson", "JsonParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonParser>.NativeClassPtr);
			JsonParser.NativeFieldInfoPtr_splitArrayPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "splitArrayPool");
			JsonParser.NativeFieldInfoPtr_MKzsAnINhmsgzVZZDhhyrBUTfHv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "MKzsAnINhmsgzVZZDhhyrBUTfHv");
			JsonParser.NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "NMTVJtrJoYumHwXWPbrJysMwPVR");
			JsonParser.NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "pAGfnheFMaBVdmJCJXDfGEBrDpI");
			JsonParser.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "YtejDiqaLAxxRnmscggDavQFcLz");
			JsonParser.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "ikzytTXFFDqNPkVCCmeRclgjukz");
			JsonParser.NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "LSUfbRdNVkGYkofhpojegAuXaApi");
			JsonParser.NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, "xKHIFFzxxSCqQovYtTvauauWzuS");
			JsonParser.NativeMethodInfoPtr_TryFromJson_Public_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675752);
			JsonParser.NativeMethodInfoPtr_TryFromJson_Internal_Static_Boolean_String_byref_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675753);
			JsonParser.NativeMethodInfoPtr_FromJson_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675754);
			JsonParser.NativeMethodInfoPtr_FromJson_Internal_Static_T_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675755);
			JsonParser.NativeMethodInfoPtr_FromJson_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675756);
			JsonParser.NativeMethodInfoPtr_FromJson_Internal_Static_Object_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675757);
			JsonParser.NativeMethodInfoPtr_JglMEVhPSUZTLaNyvhuNRoTYpHh_Private_Static_Object_Type_String_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675758);
			JsonParser.NativeMethodInfoPtr_KWQHlHDVlNHlsXbzMPDXDICRnai_Private_Static_Object_String_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675759);
			JsonParser.NativeMethodInfoPtr_LTYjAufAQqGrpEViwIArRJSvCoXo_Private_Static_Object_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675760);
			JsonParser.NativeMethodInfoPtr_jwuqUXuEykwPPqVHgBbMTzgSNbW_Private_Static_Int32_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675761);
			JsonParser.NativeMethodInfoPtr_YBkduynWHdEYCbedODjeenCuxLBY_Private_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675762);
			JsonParser.NativeMethodInfoPtr_kfYeNByLwpnQLEDyxThlXThmmZc_Private_Static_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675763);
			JsonParser.NativeMethodInfoPtr_MVnqFFZIDwCQkImnRMtwpbeynNce_Private_Static_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675764);
			JsonParser.NativeMethodInfoPtr_kICdFntJnljxpCeqIrGubGmPERd_Private_Static_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675765);
			JsonParser.NativeMethodInfoPtr_gPFDMBcCOPMkuHCdAniczNHRleXQ_Private_Static_String_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonParser>.NativeClassPtr, 100675766);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000F3488 File Offset: 0x000F1688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335734, XrefRangeEnd = 335737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFromJson<T>(string json, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JsonParser.MethodInfoStoreGeneric_TryFromJson_Public_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000F3518 File Offset: 0x000F1718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335737, XrefRangeEnd = 335769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFromJson<T>(string json, out T value, Type preferredAnonymousObjectType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preferredAnonymousObjectType);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JsonParser.MethodInfoStoreGeneric_TryFromJson_Internal_Static_Boolean_String_byref_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000F35BC File Offset: 0x000F17BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335769, XrefRangeEnd = 335772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FromJson<T>(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.MethodInfoStoreGeneric_FromJson_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x000F35FC File Offset: 0x000F17FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335800, RefRangeEnd = 335801, XrefRangeStart = 335772, XrefRangeEnd = 335800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FromJson<T>(string json, Type preferredAnonymousObjectType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preferredAnonymousObjectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.MethodInfoStoreGeneric_FromJson_Internal_Static_T_String_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x000F364C File Offset: 0x000F184C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335801, XrefRangeEnd = 335805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromJson(Type type, string json)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_FromJson_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x000F36A4 File Offset: 0x000F18A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335827, RefRangeEnd = 335828, XrefRangeStart = 335805, XrefRangeEnd = 335827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromJson(Type type, string json, Type preferredAnonymousObjectType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(json);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preferredAnonymousObjectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_FromJson_Internal_Static_Object_Type_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x000F370C File Offset: 0x000F190C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 336097, RefRangeEnd = 336108, XrefRangeStart = 335828, XrefRangeEnd = 336097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object JglMEVhPSUZTLaNyvhuNRoTYpHh(Type A_0, string A_1, Type A_2, out bool A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_JglMEVhPSUZTLaNyvhuNRoTYpHh_Private_Static_Object_Type_String_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x000F3784 File Offset: 0x000F1984
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 336230, RefRangeEnd = 336236, XrefRangeStart = 336108, XrefRangeEnd = 336230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object KWQHlHDVlNHlsXbzMPDXDICRnai(string A_0, Type A_1, out bool A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_KWQHlHDVlNHlsXbzMPDXDICRnai_Private_Static_Object_String_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x000F37E8 File Offset: 0x000F19E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336364, RefRangeEnd = 336365, XrefRangeStart = 336236, XrefRangeEnd = 336364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object LTYjAufAQqGrpEViwIArRJSvCoXo(Type A_0, string A_1, Type A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_LTYjAufAQqGrpEViwIArRJSvCoXo_Private_Static_Object_Type_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x000F3850 File Offset: 0x000F1A50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336392, RefRangeEnd = 336396, XrefRangeStart = 336365, XrefRangeEnd = 336392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int jwuqUXuEykwPPqVHgBbMTzgSNbW(bool A_0, int A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_jwuqUXuEykwPPqVHgBbMTzgSNbW_Private_Static_Int32_Boolean_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x000F38B0 File Offset: 0x000F1AB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 336446, RefRangeEnd = 336452, XrefRangeStart = 336396, XrefRangeEnd = 336446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> YBkduynWHdEYCbedODjeenCuxLBY(string A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_YBkduynWHdEYCbedODjeenCuxLBY_Private_Static_List_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000F38F4 File Offset: 0x000F1AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336452, XrefRangeEnd = 336469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool kfYeNByLwpnQLEDyxThlXThmmZc(FieldInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_kfYeNByLwpnQLEDyxThlXThmmZc_Private_Static_Boolean_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x000F3938 File Offset: 0x000F1B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336469, XrefRangeEnd = 336483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MVnqFFZIDwCQkImnRMtwpbeynNce(FieldInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_MVnqFFZIDwCQkImnRMtwpbeynNce_Private_Static_String_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000F3974 File Offset: 0x000F1B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336483, XrefRangeEnd = 336494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool kICdFntJnljxpCeqIrGubGmPERd(PropertyInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_kICdFntJnljxpCeqIrGubGmPERd_Private_Static_Boolean_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000F39B8 File Offset: 0x000F1BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336494, XrefRangeEnd = 336508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string gPFDMBcCOPMkuHCdAniczNHRleXQ(PropertyInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonParser.NativeMethodInfoPtr_gPFDMBcCOPMkuHCdAniczNHRleXQ_Private_Static_String_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00011988 File Offset: 0x0000FB88
		public JsonParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x000F39F4 File Offset: 0x000F1BF4
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x00011991 File Offset: 0x0000FB91
		public unsafe static Stack<List<string>> splitArrayPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_splitArrayPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_splitArrayPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x000F3A1C File Offset: 0x000F1C1C
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x000119A3 File Offset: 0x0000FBA3
		public unsafe static StringBuilder MKzsAnINhmsgzVZZDhhyrBUTfHv
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_MKzsAnINhmsgzVZZDhhyrBUTfHv, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_MKzsAnINhmsgzVZZDhhyrBUTfHv, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x000F3A44 File Offset: 0x000F1C44
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x000119B5 File Offset: 0x0000FBB5
		public unsafe static Dictionary<Type, Dictionary<string, FieldInfo>> NMTVJtrJoYumHwXWPbrJysMwPVR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Dictionary<string, FieldInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x000F3A6C File Offset: 0x000F1C6C
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x000119C7 File Offset: 0x0000FBC7
		public unsafe static Dictionary<Type, Dictionary<string, PropertyInfo>> pAGfnheFMaBVdmJCJXDfGEBrDpI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Dictionary<string, PropertyInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x000F3A94 File Offset: 0x000F1C94
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x000119D9 File Offset: 0x0000FBD9
		public unsafe static Func<FieldInfo, bool> YtejDiqaLAxxRnmscggDavQFcLz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000F3ABC File Offset: 0x000F1CBC
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x000119EB File Offset: 0x0000FBEB
		public unsafe static Func<FieldInfo, string> ikzytTXFFDqNPkVCCmeRclgjukz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000F3AE4 File Offset: 0x000F1CE4
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x000119FD File Offset: 0x0000FBFD
		public unsafe static Func<PropertyInfo, bool> LSUfbRdNVkGYkofhpojegAuXaApi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PropertyInfo, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000F3B0C File Offset: 0x000F1D0C
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x00011A0F File Offset: 0x0000FC0F
		public unsafe static Func<PropertyInfo, string> xKHIFFzxxSCqQovYtTvauauWzuS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonParser.NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PropertyInfo, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonParser.NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeFieldInfoPtr_splitArrayPool;

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeFieldInfoPtr_MKzsAnINhmsgzVZZDhhyrBUTfHv;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeFieldInfoPtr_NMTVJtrJoYumHwXWPbrJysMwPVR;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeFieldInfoPtr_pAGfnheFMaBVdmJCJXDfGEBrDpI;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeFieldInfoPtr_LSUfbRdNVkGYkofhpojegAuXaApi;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeFieldInfoPtr_xKHIFFzxxSCqQovYtTvauauWzuS;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeMethodInfoPtr_TryFromJson_Public_Static_Boolean_String_byref_T_0;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeMethodInfoPtr_TryFromJson_Internal_Static_Boolean_String_byref_T_Type_0;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_T_String_0;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Internal_Static_T_String_Type_0;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Object_Type_String_0;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Internal_Static_Object_Type_String_Type_0;

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeMethodInfoPtr_JglMEVhPSUZTLaNyvhuNRoTYpHh_Private_Static_Object_Type_String_Type_byref_Boolean_0;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeMethodInfoPtr_KWQHlHDVlNHlsXbzMPDXDICRnai_Private_Static_Object_String_Type_byref_Boolean_0;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeMethodInfoPtr_LTYjAufAQqGrpEViwIArRJSvCoXo_Private_Static_Object_Type_String_Type_0;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeMethodInfoPtr_jwuqUXuEykwPPqVHgBbMTzgSNbW_Private_Static_Int32_Boolean_Int32_String_0;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeMethodInfoPtr_YBkduynWHdEYCbedODjeenCuxLBY_Private_Static_List_1_String_String_0;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr_kfYeNByLwpnQLEDyxThlXThmmZc_Private_Static_Boolean_FieldInfo_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_MVnqFFZIDwCQkImnRMtwpbeynNce_Private_Static_String_FieldInfo_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr_kICdFntJnljxpCeqIrGubGmPERd_Private_Static_Boolean_PropertyInfo_0;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeMethodInfoPtr_gPFDMBcCOPMkuHCdAniczNHRleXQ_Private_Static_String_PropertyInfo_0;

		// Token: 0x020003F7 RID: 1015
		private sealed class MethodInfoStoreGeneric_TryFromJson_Public_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x0400432A RID: 17194
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonParser.NativeMethodInfoPtr_TryFromJson_Public_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<JsonParser>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003F8 RID: 1016
		private sealed class MethodInfoStoreGeneric_TryFromJson_Internal_Static_Boolean_String_byref_T_Type_0<T>
		{
			// Token: 0x0400432B RID: 17195
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonParser.NativeMethodInfoPtr_TryFromJson_Internal_Static_Boolean_String_byref_T_Type_0, Il2CppClassPointerStore<JsonParser>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003F9 RID: 1017
		private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_T_String_0<T>
		{
			// Token: 0x0400432C RID: 17196
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonParser.NativeMethodInfoPtr_FromJson_Public_Static_T_String_0, Il2CppClassPointerStore<JsonParser>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003FA RID: 1018
		private sealed class MethodInfoStoreGeneric_FromJson_Internal_Static_T_String_Type_0<T>
		{
			// Token: 0x0400432D RID: 17197
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonParser.NativeMethodInfoPtr_FromJson_Internal_Static_T_String_Type_0, Il2CppClassPointerStore<JsonParser>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
