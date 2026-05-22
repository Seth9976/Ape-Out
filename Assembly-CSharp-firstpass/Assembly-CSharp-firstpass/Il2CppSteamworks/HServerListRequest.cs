using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000167 RID: 359
	[Serializable]
	[StructLayout(2)]
	public struct HServerListRequest
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x0004C980 File Offset: 0x0004AB80
		// Note: this type is marked as 'beforefieldinit'.
		static HServerListRequest()
		{
			Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HServerListRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr);
			HServerListRequest.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, "Invalid");
			HServerListRequest.NativeFieldInfoPtr_m_HServerListRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, "m_HServerListRequest");
			HServerListRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665497);
			HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665498);
			HServerListRequest.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665499);
			HServerListRequest.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665500);
			HServerListRequest.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665501);
			HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerListRequest_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665502);
			HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665503);
			HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100665504);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0004CA78 File Offset: 0x0004AC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13398, XrefRangeEnd = 13399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13399, XrefRangeEnd = 13403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004CAE8 File Offset: 0x0004ACE8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004CB18 File Offset: 0x0004AD18
		[CallerCount(0)]
		public unsafe static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004CB64 File Offset: 0x0004AD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13403, XrefRangeEnd = 13406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HServerListRequest(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerListRequest_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0004CBF0 File Offset: 0x0004ADF0
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(HServerListRequest that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0004CC30 File Offset: 0x0004AE30
		[CallerCount(0)]
		public unsafe bool Equals(HServerListRequest other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000069E8 File Offset: 0x00004BE8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0004CC70 File Offset: 0x0004AE70
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x000069FA File Offset: 0x00004BFA
		public unsafe static HServerListRequest Invalid
		{
			get
			{
				HServerListRequest hserverListRequest;
				IL2CPP.il2cpp_field_static_get_value(HServerListRequest.NativeFieldInfoPtr_Invalid, (void*)(&hserverListRequest));
				return hserverListRequest;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HServerListRequest.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr_m_HServerListRequest;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HServerListRequest_IntPtr_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_HServerListRequest_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0;

		// Token: 0x040011CF RID: 4559
		[FieldOffset(0)]
		public IntPtr m_HServerListRequest;
	}
}
