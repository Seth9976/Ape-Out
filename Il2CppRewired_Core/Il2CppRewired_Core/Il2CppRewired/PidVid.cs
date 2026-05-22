using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200002F RID: 47
	[StructLayout(2)]
	public struct PidVid
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0003B1CC File Offset: 0x000393CC
		// Note: this type is marked as 'beforefieldinit'.
		static PidVid()
		{
			Il2CppClassPointerStore<PidVid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PidVid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PidVid>.NativeClassPtr);
			PidVid.NativeFieldInfoPtr_PtnZPcXvZaWqRntTksVBVRTvIaD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PidVid>.NativeClassPtr, "PtnZPcXvZaWqRntTksVBVRTvIaD");
			PidVid.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PidVid>.NativeClassPtr, "productId");
			PidVid.NativeFieldInfoPtr_vendorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PidVid>.NativeClassPtr, "vendorId");
			PidVid.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663857);
			PidVid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663858);
			PidVid.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663859);
			PidVid.NativeMethodInfoPtr_get_isZero_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663860);
			PidVid.NativeMethodInfoPtr_Equals_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663861);
			PidVid.NativeMethodInfoPtr_ToProductGuid_Public_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663862);
			PidVid.NativeMethodInfoPtr_exsbzOovGUhYahWfwNZVdBQCFeXV_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663863);
			PidVid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663864);
			PidVid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663865);
			PidVid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PidVid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663866);
			PidVid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PidVid_PidVid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663867);
			PidVid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PidVid_PidVid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663868);
			PidVid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663869);
			PidVid.NativeMethodInfoPtr_ArrayContains_Public_Static_Boolean_Il2CppStringArray_byref_PidVid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663870);
			PidVid.NativeMethodInfoPtr_HUUoPNnlIyrAnPDGRjViHrqNLVzp_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PidVid>.NativeClassPtr, 100663871);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0003B364 File Offset: 0x00039564
		[CallerCount(0)]
		public unsafe PidVid(ushort productId, ushort vendorId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref productId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vendorId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0003B3A4 File Offset: 0x000395A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244674, RefRangeEnd = 244682, XrefRangeStart = 244666, XrefRangeEnd = 244674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PidVid(string pidVid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pidVid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0003B3DC File Offset: 0x000395DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244682, XrefRangeEnd = 244687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PidVid(Guid productGuid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref productGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0003B410 File Offset: 0x00039610
		public unsafe bool isZero
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_get_isZero_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0003B440 File Offset: 0x00039640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244687, XrefRangeEnd = 244689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string pidVid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pidVid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_Equals_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0003B484 File Offset: 0x00039684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244689, XrefRangeEnd = 244693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid ToProductGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_ToProductGuid_Public_Guid_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0003B4B4 File Offset: 0x000396B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 244701, RefRangeEnd = 244704, XrefRangeStart = 244693, XrefRangeEnd = 244701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool exsbzOovGUhYahWfwNZVdBQCFeXV(string A_1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_exsbzOovGUhYahWfwNZVdBQCFeXV_Private_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0003B4F8 File Offset: 0x000396F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244704, XrefRangeEnd = 244706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0003B53C File Offset: 0x0003973C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0003B56C File Offset: 0x0003976C
		[CallerCount(0)]
		public unsafe bool Equals(PidVid other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PidVid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0003B5AC File Offset: 0x000397AC
		[CallerCount(0)]
		public unsafe static bool operator ==(PidVid x, PidVid y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PidVid_PidVid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0003B5F8 File Offset: 0x000397F8
		[CallerCount(0)]
		public unsafe static bool operator !=(PidVid x, PidVid y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PidVid_PidVid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0003B644 File Offset: 0x00039844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244714, RefRangeEnd = 244715, XrefRangeStart = 244706, XrefRangeEnd = 244714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0003B670 File Offset: 0x00039870
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 244718, RefRangeEnd = 244721, XrefRangeStart = 244715, XrefRangeEnd = 244718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayContains(Il2CppStringArray pidVids, ref PidVid vidPid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pidVids);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vidPid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_ArrayContains_Public_Static_Boolean_Il2CppStringArray_byref_PidVid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0003B6C0 File Offset: 0x000398C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 244733, RefRangeEnd = 244737, XrefRangeStart = 244721, XrefRangeEnd = 244733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string HUUoPNnlIyrAnPDGRjViHrqNLVzp(string A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PidVid.NativeMethodInfoPtr_HUUoPNnlIyrAnPDGRjViHrqNLVzp_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003281 File Offset: 0x00001481
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PidVid>.NativeClassPtr, ref this));
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0003B6FC File Offset: 0x000398FC
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00003293 File Offset: 0x00001493
		public unsafe static string PtnZPcXvZaWqRntTksVBVRTvIaD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PidVid.NativeFieldInfoPtr_PtnZPcXvZaWqRntTksVBVRTvIaD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PidVid.NativeFieldInfoPtr_PtnZPcXvZaWqRntTksVBVRTvIaD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_PtnZPcXvZaWqRntTksVBVRTvIaD;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_productId;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_vendorId;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_isZero_Public_get_Boolean_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_String_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_ToProductGuid_Public_Guid_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_exsbzOovGUhYahWfwNZVdBQCFeXV_Private_Boolean_String_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PidVid_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PidVid_PidVid_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PidVid_PidVid_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_ArrayContains_Public_Static_Boolean_Il2CppStringArray_byref_PidVid_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_HUUoPNnlIyrAnPDGRjViHrqNLVzp_Private_Static_String_String_0;

		// Token: 0x04000309 RID: 777
		[FieldOffset(0)]
		public ushort productId;

		// Token: 0x0400030A RID: 778
		[FieldOffset(2)]
		public ushort vendorId;
	}
}
