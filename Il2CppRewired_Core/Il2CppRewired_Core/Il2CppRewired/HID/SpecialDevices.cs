using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000122 RID: 290
	public static class SpecialDevices : Object
	{
		// Token: 0x06001DBB RID: 7611 RVA: 0x0009D710 File Offset: 0x0009B910
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialDevices()
		{
			Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "SpecialDevices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr);
			SpecialDevices.NativeFieldInfoPtr_ngUDpRAwYuFNHEEXWaWmjJkillV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, "ngUDpRAwYuFNHEEXWaWmjJkillV");
			SpecialDevices.NativeFieldInfoPtr_UhPpffJEGhQyyRETOaiBjqtYnmG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, "UhPpffJEGhQyyRETOaiBjqtYnmG");
			SpecialDevices.NativeMethodInfoPtr_RequiresRelativeToAbsoluteAxisConversion_Public_Static_Boolean_UInt16_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669810);
			SpecialDevices.NativeMethodInfoPtr_GetRelativeToAbsoluteAxisEventTimeout_Public_Static_Single_UInt16_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669811);
			SpecialDevices.NativeMethodInfoPtr_GetRelativeAxisRanges_Public_Static_Boolean_UInt16_UInt16_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669812);
			SpecialDevices.NativeMethodInfoPtr_GetRelativeAxisRanges_Public_Static_Boolean_UInt16_UInt16_String_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669813);
			SpecialDevices.NativeMethodInfoPtr_IsSupportedSpecialDevice_Public_Static_Boolean_UInt16_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669814);
			SpecialDevices.NativeMethodInfoPtr_qWdiVkJtFtBRnHcZNJVWghsCaDTd_Private_Static_Boolean_UInt16_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669815);
			SpecialDevices.NativeMethodInfoPtr_erFcDgSHnSkRVCmTZnoORHpehCL_Private_Static_pXOYgsrLpzhYyaARSIizCGnatexP_UInt16_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, 100669816);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0009D7F4 File Offset: 0x0009B9F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280739, RefRangeEnd = 280740, XrefRangeStart = 280735, XrefRangeEnd = 280739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequiresRelativeToAbsoluteAxisConversion(ushort vendorId, ushort productId, string productName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_RequiresRelativeToAbsoluteAxisConversion_Public_Static_Boolean_UInt16_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0009D854 File Offset: 0x0009BA54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280744, RefRangeEnd = 280745, XrefRangeStart = 280740, XrefRangeEnd = 280744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRelativeToAbsoluteAxisEventTimeout(ushort vendorId, ushort productId, string productName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_GetRelativeToAbsoluteAxisEventTimeout_Public_Static_Single_UInt16_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0009D8B4 File Offset: 0x0009BAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280745, XrefRangeEnd = 280749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, out int min, out int max, out int zero)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &zero;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_GetRelativeAxisRanges_Public_Static_Boolean_UInt16_UInt16_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0009D92C File Offset: 0x0009BB2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280762, RefRangeEnd = 280764, XrefRangeStart = 280749, XrefRangeEnd = 280762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, string productName, out int min, out int max, out int zero)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &zero;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_GetRelativeAxisRanges_Public_Static_Boolean_UInt16_UInt16_String_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0009D9B8 File Offset: 0x0009BBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280764, XrefRangeEnd = 280777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSupportedSpecialDevice(ushort vendorId, ushort productId, string productName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_IsSupportedSpecialDevice_Public_Static_Boolean_UInt16_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0009DA18 File Offset: 0x0009BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280777, XrefRangeEnd = 280785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool qWdiVkJtFtBRnHcZNJVWghsCaDTd(ushort A_0, ushort A_1, string A_2 = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_qWdiVkJtFtBRnHcZNJVWghsCaDTd_Private_Static_Boolean_UInt16_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0009DA78 File Offset: 0x0009BC78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280796, RefRangeEnd = 280798, XrefRangeStart = 280785, XrefRangeEnd = 280796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP erFcDgSHnSkRVCmTZnoORHpehCL(ushort A_0, ushort A_1, string A_2 = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.NativeMethodInfoPtr_erFcDgSHnSkRVCmTZnoORHpehCL_Private_Static_pXOYgsrLpzhYyaARSIizCGnatexP_UInt16_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>(intPtr3) : null;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0000C48E File Offset: 0x0000A68E
		public SpecialDevices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0000C497 File Offset: 0x0000A697
		public unsafe static float ngUDpRAwYuFNHEEXWaWmjJkillV
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SpecialDevices.NativeFieldInfoPtr_ngUDpRAwYuFNHEEXWaWmjJkillV, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialDevices.NativeFieldInfoPtr_ngUDpRAwYuFNHEEXWaWmjJkillV, (void*)(&value));
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0009DAF4 File Offset: 0x0009BCF4
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000C4A5 File Offset: 0x0000A6A5
		public unsafe static Il2CppReferenceArray<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP> UhPpffJEGhQyyRETOaiBjqtYnmG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpecialDevices.NativeFieldInfoPtr_UhPpffJEGhQyyRETOaiBjqtYnmG, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialDevices.NativeFieldInfoPtr_UhPpffJEGhQyyRETOaiBjqtYnmG, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeFieldInfoPtr_ngUDpRAwYuFNHEEXWaWmjJkillV;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeFieldInfoPtr_UhPpffJEGhQyyRETOaiBjqtYnmG;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_RequiresRelativeToAbsoluteAxisConversion_Public_Static_Boolean_UInt16_UInt16_String_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeToAbsoluteAxisEventTimeout_Public_Static_Single_UInt16_UInt16_String_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeAxisRanges_Public_Static_Boolean_UInt16_UInt16_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeAxisRanges_Public_Static_Boolean_UInt16_UInt16_String_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_IsSupportedSpecialDevice_Public_Static_Boolean_UInt16_UInt16_String_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_qWdiVkJtFtBRnHcZNJVWghsCaDTd_Private_Static_Boolean_UInt16_UInt16_String_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_erFcDgSHnSkRVCmTZnoORHpehCL_Private_Static_pXOYgsrLpzhYyaARSIizCGnatexP_UInt16_UInt16_String_0;

		// Token: 0x02000339 RID: 825
		public class pXOYgsrLpzhYyaARSIizCGnatexP : Object
		{
			// Token: 0x060045B6 RID: 17846 RVA: 0x00144D10 File Offset: 0x00142F10
			// Note: this type is marked as 'beforefieldinit'.
			static pXOYgsrLpzhYyaARSIizCGnatexP()
			{
				Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialDevices>.NativeClassPtr, "pXOYgsrLpzhYyaARSIizCGnatexP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr);
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_irAtOxxbLRFaOpbobsOAcTiiVra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "irAtOxxbLRFaOpbobsOAcTiiVra");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_KJwCkUZVZPAKaozwbnNvMAROdiQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "KJwCkUZVZPAKaozwbnNvMAROdiQ");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_vaPXZcTBMkvNgndQhzqGzoHZKVQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "vaPXZcTBMkvNgndQhzqGzoHZKVQ");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_vlgIArXcCzZBZzaSemPCwdaEFgV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "vlgIArXcCzZBZzaSemPCwdaEFgV");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_WPrEWQhfpiPjTGMBQABZOCtxCecc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "WPrEWQhfpiPjTGMBQABZOCtxCecc");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_FRKOaTRjYKiuMKLCIpEuNxlXHEB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "FRKOaTRjYKiuMKLCIpEuNxlXHEB");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_NSYUFlxElEESiTBpewHRfRsfpag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "NSYUFlxElEESiTBpewHRfRsfpag");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_FSVXBLpbYHVorlqYeEmSyvWvjBv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, "FSVXBLpbYHVorlqYeEmSyvWvjBv");
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_String_Boolean_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, 100669818);
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, 100669819);
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_UInt16_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, 100669820);
				SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr, 100669821);
			}

			// Token: 0x060045B7 RID: 17847 RVA: 0x00144E2C File Offset: 0x0014302C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280730, XrefRangeEnd = 280732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe pXOYgsrLpzhYyaARSIizCGnatexP(ushort vendorId, ushort productId, string productName, bool hasRelativeAxes, int axisMin, int axisMax, int axisZero, float relToAbsAxisConversionTimeout)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref vendorId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productName);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRelativeAxes;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisMin;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisMax;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisZero;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relToAbsAxisConversionTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_String_Boolean_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045B8 RID: 17848 RVA: 0x00144EDC File Offset: 0x001430DC
			[CallerCount(0)]
			public unsafe bool eAAVmzJKguqZftriUnUrhTAJQfz(ushort A_1, ushort A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_UInt16_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060045B9 RID: 17849 RVA: 0x00144F34 File Offset: 0x00143134
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 280732, RefRangeEnd = 280735, XrefRangeStart = 280732, XrefRangeEnd = 280732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool eAAVmzJKguqZftriUnUrhTAJQfz(ushort A_1, ushort A_2, string A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_UInt16_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060045BA RID: 17850 RVA: 0x00144FA0 File Offset: 0x001431A0
			[CallerCount(0)]
			public unsafe bool eAAVmzJKguqZftriUnUrhTAJQfz(string A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045BB RID: 17851 RVA: 0x000191C8 File Offset: 0x000173C8
			public pXOYgsrLpzhYyaARSIizCGnatexP(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015C0 RID: 5568
			// (get) Token: 0x060045BC RID: 17852 RVA: 0x00144FF0 File Offset: 0x001431F0
			// (set) Token: 0x060045BD RID: 17853 RVA: 0x000191D1 File Offset: 0x000173D1
			public unsafe ushort irAtOxxbLRFaOpbobsOAcTiiVra
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_irAtOxxbLRFaOpbobsOAcTiiVra);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_irAtOxxbLRFaOpbobsOAcTiiVra)) = value;
				}
			}

			// Token: 0x170015C1 RID: 5569
			// (get) Token: 0x060045BE RID: 17854 RVA: 0x00145018 File Offset: 0x00143218
			// (set) Token: 0x060045BF RID: 17855 RVA: 0x000191EC File Offset: 0x000173EC
			public unsafe ushort KJwCkUZVZPAKaozwbnNvMAROdiQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_KJwCkUZVZPAKaozwbnNvMAROdiQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_KJwCkUZVZPAKaozwbnNvMAROdiQ)) = value;
				}
			}

			// Token: 0x170015C2 RID: 5570
			// (get) Token: 0x060045C0 RID: 17856 RVA: 0x00145040 File Offset: 0x00143240
			// (set) Token: 0x060045C1 RID: 17857 RVA: 0x00019207 File Offset: 0x00017407
			public unsafe string vaPXZcTBMkvNgndQhzqGzoHZKVQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_vaPXZcTBMkvNgndQhzqGzoHZKVQ);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_vaPXZcTBMkvNgndQhzqGzoHZKVQ), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170015C3 RID: 5571
			// (get) Token: 0x060045C2 RID: 17858 RVA: 0x00145068 File Offset: 0x00143268
			// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00019226 File Offset: 0x00017426
			public unsafe bool vlgIArXcCzZBZzaSemPCwdaEFgV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_vlgIArXcCzZBZzaSemPCwdaEFgV);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_vlgIArXcCzZBZzaSemPCwdaEFgV)) = value;
				}
			}

			// Token: 0x170015C4 RID: 5572
			// (get) Token: 0x060045C4 RID: 17860 RVA: 0x00145090 File Offset: 0x00143290
			// (set) Token: 0x060045C5 RID: 17861 RVA: 0x00019241 File Offset: 0x00017441
			public unsafe int WPrEWQhfpiPjTGMBQABZOCtxCecc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_WPrEWQhfpiPjTGMBQABZOCtxCecc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_WPrEWQhfpiPjTGMBQABZOCtxCecc)) = value;
				}
			}

			// Token: 0x170015C5 RID: 5573
			// (get) Token: 0x060045C6 RID: 17862 RVA: 0x001450B8 File Offset: 0x001432B8
			// (set) Token: 0x060045C7 RID: 17863 RVA: 0x0001925C File Offset: 0x0001745C
			public unsafe int FRKOaTRjYKiuMKLCIpEuNxlXHEB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_FRKOaTRjYKiuMKLCIpEuNxlXHEB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_FRKOaTRjYKiuMKLCIpEuNxlXHEB)) = value;
				}
			}

			// Token: 0x170015C6 RID: 5574
			// (get) Token: 0x060045C8 RID: 17864 RVA: 0x001450E0 File Offset: 0x001432E0
			// (set) Token: 0x060045C9 RID: 17865 RVA: 0x00019277 File Offset: 0x00017477
			public unsafe int NSYUFlxElEESiTBpewHRfRsfpag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_NSYUFlxElEESiTBpewHRfRsfpag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_NSYUFlxElEESiTBpewHRfRsfpag)) = value;
				}
			}

			// Token: 0x170015C7 RID: 5575
			// (get) Token: 0x060045CA RID: 17866 RVA: 0x00145108 File Offset: 0x00143308
			// (set) Token: 0x060045CB RID: 17867 RVA: 0x00019292 File Offset: 0x00017492
			public unsafe float FSVXBLpbYHVorlqYeEmSyvWvjBv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_FSVXBLpbYHVorlqYeEmSyvWvjBv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialDevices.pXOYgsrLpzhYyaARSIizCGnatexP.NativeFieldInfoPtr_FSVXBLpbYHVorlqYeEmSyvWvjBv)) = value;
				}
			}

			// Token: 0x040038F9 RID: 14585
			private static readonly IntPtr NativeFieldInfoPtr_irAtOxxbLRFaOpbobsOAcTiiVra;

			// Token: 0x040038FA RID: 14586
			private static readonly IntPtr NativeFieldInfoPtr_KJwCkUZVZPAKaozwbnNvMAROdiQ;

			// Token: 0x040038FB RID: 14587
			private static readonly IntPtr NativeFieldInfoPtr_vaPXZcTBMkvNgndQhzqGzoHZKVQ;

			// Token: 0x040038FC RID: 14588
			private static readonly IntPtr NativeFieldInfoPtr_vlgIArXcCzZBZzaSemPCwdaEFgV;

			// Token: 0x040038FD RID: 14589
			private static readonly IntPtr NativeFieldInfoPtr_WPrEWQhfpiPjTGMBQABZOCtxCecc;

			// Token: 0x040038FE RID: 14590
			private static readonly IntPtr NativeFieldInfoPtr_FRKOaTRjYKiuMKLCIpEuNxlXHEB;

			// Token: 0x040038FF RID: 14591
			private static readonly IntPtr NativeFieldInfoPtr_NSYUFlxElEESiTBpewHRfRsfpag;

			// Token: 0x04003900 RID: 14592
			private static readonly IntPtr NativeFieldInfoPtr_FSVXBLpbYHVorlqYeEmSyvWvjBv;

			// Token: 0x04003901 RID: 14593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_String_Boolean_Int32_Int32_Int32_Single_0;

			// Token: 0x04003902 RID: 14594
			private static readonly IntPtr NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_UInt16_UInt16_0;

			// Token: 0x04003903 RID: 14595
			private static readonly IntPtr NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_UInt16_UInt16_String_0;

			// Token: 0x04003904 RID: 14596
			private static readonly IntPtr NativeMethodInfoPtr_eAAVmzJKguqZftriUnUrhTAJQfz_Public_Boolean_String_0;
		}
	}
}
