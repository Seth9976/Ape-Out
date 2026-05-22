using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		// Token: 0x06000CFA RID: 3322 RVA: 0x000417A8 File Offset: 0x0003F9A8
		// Note: this type is marked as 'beforefieldinit'.
		static IPEndPoint()
		{
			Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPEndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr);
			IPEndPoint.NativeFieldInfoPtr_MinPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "MinPort");
			IPEndPoint.NativeFieldInfoPtr_MaxPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "MaxPort");
			IPEndPoint.NativeFieldInfoPtr_m_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "m_Address");
			IPEndPoint.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "m_Port");
			IPEndPoint.NativeFieldInfoPtr_AnyPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "AnyPort");
			IPEndPoint.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "Any");
			IPEndPoint.NativeFieldInfoPtr_IPv6Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "IPv6Any");
			IPEndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665180);
			IPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665181);
			IPEndPoint.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665182);
			IPEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665183);
			IPEndPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665184);
			IPEndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665185);
			IPEndPoint.NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665186);
			IPEndPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665187);
			IPEndPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100665188);
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00041918 File Offset: 0x0003FB18
		public unsafe override AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00041960 File Offset: 0x0003FB60
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 376691, RefRangeEnd = 376700, XrefRangeStart = 376688, XrefRangeEnd = 376691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint(IPAddress address, int port)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000419BC File Offset: 0x0003FBBC
		public unsafe IPAddress Address
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000419FC File Offset: 0x0003FBFC
		public unsafe int Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00041A38 File Offset: 0x0003FC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376700, XrefRangeEnd = 376709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00041A7C File Offset: 0x0003FC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376709, XrefRangeEnd = 376713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SocketAddress Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00041AC8 File Offset: 0x0003FCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376713, XrefRangeEnd = 376718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EndPoint Create(SocketAddress socketAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socketAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00041B24 File Offset: 0x0003FD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376718, XrefRangeEnd = 376721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00041B7C File Offset: 0x0003FD7C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000071D6 File Offset: 0x000053D6
		public IPEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00041BC4 File Offset: 0x0003FDC4
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x000071DF File Offset: 0x000053DF
		public unsafe static int MinPort
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_MinPort, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_MinPort, (void*)(&value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00041BE0 File Offset: 0x0003FDE0
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x000071ED File Offset: 0x000053ED
		public unsafe static int MaxPort
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_MaxPort, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_MaxPort, (void*)(&value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00041BFC File Offset: 0x0003FDFC
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x000071FB File Offset: 0x000053FB
		public unsafe IPAddress m_Address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00041C2C File Offset: 0x0003FE2C
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x0000721A File Offset: 0x0000541A
		public unsafe int m_Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Port)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00041C54 File Offset: 0x0003FE54
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00007235 File Offset: 0x00005435
		public unsafe static int AnyPort
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_AnyPort, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_AnyPort, (void*)(&value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00041C70 File Offset: 0x0003FE70
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00007243 File Offset: 0x00005443
		public unsafe static IPEndPoint Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00041C98 File Offset: 0x0003FE98
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00007255 File Offset: 0x00005455
		public unsafe static IPEndPoint IPv6Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_IPv6Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_IPv6Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_MinPort;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeFieldInfoPtr_MaxPort;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr_m_Address;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr_m_Port;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr_AnyPort;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Any;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
