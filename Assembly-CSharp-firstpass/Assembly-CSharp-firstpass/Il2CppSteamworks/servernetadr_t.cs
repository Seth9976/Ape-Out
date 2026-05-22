using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000153 RID: 339
	[Serializable]
	[StructLayout(2)]
	public struct servernetadr_t
	{
		// Token: 0x06000E41 RID: 3649 RVA: 0x000475A0 File Offset: 0x000457A0
		// Note: this type is marked as 'beforefieldinit'.
		static servernetadr_t()
		{
			Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "servernetadr_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr);
			servernetadr_t.NativeFieldInfoPtr_m_usConnectionPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "m_usConnectionPort");
			servernetadr_t.NativeFieldInfoPtr_m_usQueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "m_usQueryPort");
			servernetadr_t.NativeFieldInfoPtr_m_unIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "m_unIP");
			servernetadr_t.NativeMethodInfoPtr_Init_Public_Void_UInt32_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665246);
			servernetadr_t.NativeMethodInfoPtr_GetQueryPort_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665247);
			servernetadr_t.NativeMethodInfoPtr_SetQueryPort_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665248);
			servernetadr_t.NativeMethodInfoPtr_GetConnectionPort_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665249);
			servernetadr_t.NativeMethodInfoPtr_SetConnectionPort_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665250);
			servernetadr_t.NativeMethodInfoPtr_GetIP_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665251);
			servernetadr_t.NativeMethodInfoPtr_SetIP_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665252);
			servernetadr_t.NativeMethodInfoPtr_GetConnectionAddressString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665253);
			servernetadr_t.NativeMethodInfoPtr_GetQueryAddressString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665254);
			servernetadr_t.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665255);
			servernetadr_t.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665256);
			servernetadr_t.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665257);
			servernetadr_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665258);
			servernetadr_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665259);
			servernetadr_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665260);
			servernetadr_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665261);
			servernetadr_t.NativeMethodInfoPtr_Equals_Public_Boolean_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665262);
			servernetadr_t.NativeMethodInfoPtr_CompareTo_Public_Int32_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100665263);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00047774 File Offset: 0x00045974
		[CallerCount(0)]
		public unsafe void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usQueryPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usConnectionPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_Init_Public_Void_UInt32_UInt16_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000477C4 File Offset: 0x000459C4
		[CallerCount(0)]
		public unsafe ushort GetQueryPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetQueryPort_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000477F4 File Offset: 0x000459F4
		[CallerCount(0)]
		public unsafe void SetQueryPort(ushort usPort)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_SetQueryPort_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00047828 File Offset: 0x00045A28
		[CallerCount(0)]
		public unsafe ushort GetConnectionPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetConnectionPort_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00047858 File Offset: 0x00045A58
		[CallerCount(0)]
		public unsafe void SetConnectionPort(ushort usPort)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_SetConnectionPort_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0004788C File Offset: 0x00045A8C
		[CallerCount(0)]
		public unsafe uint GetIP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetIP_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000478BC File Offset: 0x00045ABC
		[CallerCount(0)]
		public unsafe void SetIP(uint unIP)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_SetIP_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000478F0 File Offset: 0x00045AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12817, XrefRangeEnd = 12818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConnectionAddressString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetConnectionAddressString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0004791C File Offset: 0x00045B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12818, XrefRangeEnd = 12819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQueryAddressString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetQueryAddressString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00047948 File Offset: 0x00045B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12858, RefRangeEnd = 12860, XrefRangeStart = 12819, XrefRangeEnd = 12858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(uint unIP, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00047990 File Offset: 0x00045B90
		[CallerCount(0)]
		public unsafe static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000479DC File Offset: 0x00045BDC
		[CallerCount(0)]
		public unsafe static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00047A28 File Offset: 0x00045C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12860, XrefRangeEnd = 12862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00047A6C File Offset: 0x00045C6C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00047A9C File Offset: 0x00045C9C
		[CallerCount(0)]
		public unsafe static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00047AE8 File Offset: 0x00045CE8
		[CallerCount(0)]
		public unsafe static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00047B34 File Offset: 0x00045D34
		[CallerCount(0)]
		public unsafe bool Equals(servernetadr_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_Equals_Public_Boolean_servernetadr_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00047B74 File Offset: 0x00045D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12862, XrefRangeEnd = 12863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(servernetadr_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_CompareTo_Public_Int32_servernetadr_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0000678E File Offset: 0x0000498E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeFieldInfoPtr_m_usConnectionPort;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr_m_usQueryPort;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr_m_unIP;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_UInt32_UInt16_UInt16_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryPort_Public_UInt16_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_SetQueryPort_Public_Void_UInt16_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionPort_Public_UInt16_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionPort_Public_Void_UInt16_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_GetIP_Public_UInt32_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_SetIP_Public_Void_UInt32_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddressString_Public_String_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryAddressString_Public_String_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_UInt16_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_servernetadr_t_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_servernetadr_t_0;

		// Token: 0x040010B4 RID: 4276
		[FieldOffset(0)]
		public ushort m_usConnectionPort;

		// Token: 0x040010B5 RID: 4277
		[FieldOffset(2)]
		public ushort m_usQueryPort;

		// Token: 0x040010B6 RID: 4278
		[FieldOffset(4)]
		public uint m_unIP;
	}
}
