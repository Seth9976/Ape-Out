using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class IPAddress : Object
	{
		// Token: 0x06000CC6 RID: 3270 RVA: 0x00040DA4 File Offset: 0x0003EFA4
		// Note: this type is marked as 'beforefieldinit'.
		static IPAddress()
		{
			Il2CppClassPointerStore<IPAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPAddress>.NativeClassPtr);
			IPAddress.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Any");
			IPAddress.NativeFieldInfoPtr_Loopback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Loopback");
			IPAddress.NativeFieldInfoPtr_Broadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Broadcast");
			IPAddress.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "None");
			IPAddress.NativeFieldInfoPtr_LoopbackMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "LoopbackMask");
			IPAddress.NativeFieldInfoPtr_m_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_Address");
			IPAddress.NativeFieldInfoPtr_m_ToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_ToString");
			IPAddress.NativeFieldInfoPtr_IPv6Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6Any");
			IPAddress.NativeFieldInfoPtr_IPv6Loopback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6Loopback");
			IPAddress.NativeFieldInfoPtr_IPv6None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6None");
			IPAddress.NativeFieldInfoPtr_m_Family = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_Family");
			IPAddress.NativeFieldInfoPtr_m_Numbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_Numbers");
			IPAddress.NativeFieldInfoPtr_m_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_ScopeId");
			IPAddress.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_HashCode");
			IPAddress.NativeFieldInfoPtr_IPv4AddressBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv4AddressBytes");
			IPAddress.NativeFieldInfoPtr_IPv6AddressBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6AddressBytes");
			IPAddress.NativeFieldInfoPtr_NumberOfLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "NumberOfLabels");
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665163);
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665164);
			IPAddress.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665165);
			IPAddress.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665166);
			IPAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665167);
			IPAddress.NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665168);
			IPAddress.NativeMethodInfoPtr_InternalParse_Private_Static_IPAddress_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665169);
			IPAddress.NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665170);
			IPAddress.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665171);
			IPAddress.NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665172);
			IPAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665173);
			IPAddress.NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665174);
			IPAddress.NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665175);
			IPAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665176);
			IPAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665177);
			IPAddress.NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100665178);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00041068 File Offset: 0x0003F268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376621, RefRangeEnd = 376624, XrefRangeStart = 376618, XrefRangeEnd = 376621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(long newAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000410B0 File Offset: 0x0003F2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376624, XrefRangeEnd = 376627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<byte> address, long scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0004110C File Offset: 0x0003F30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376630, RefRangeEnd = 376632, XrefRangeStart = 376627, XrefRangeEnd = 376630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<ushort> address, uint scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00041168 File Offset: 0x0003F368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376632, XrefRangeEnd = 376635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(int newAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000411B0 File Offset: 0x0003F3B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376639, RefRangeEnd = 376641, XrefRangeStart = 376635, XrefRangeEnd = 376639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string ipString, out IPAddress address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			address = ((intPtr4 == 0) ? null : new IPAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00041214 File Offset: 0x0003F414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376645, RefRangeEnd = 376646, XrefRangeStart = 376641, XrefRangeEnd = 376645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress Parse(string ipString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00041258 File Offset: 0x0003F458
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 376654, RefRangeEnd = 376659, XrefRangeStart = 376646, XrefRangeEnd = 376654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress InternalParse(string ipString, bool tryParse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_InternalParse_Private_Static_IPAddress_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000412AC File Offset: 0x0003F4AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376662, RefRangeEnd = 376665, XrefRangeStart = 376659, XrefRangeEnd = 376662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetAddressBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000412EC File Offset: 0x0003F4EC
		public unsafe AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00041328 File Offset: 0x0003F528
		public unsafe long ScopeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00041364 File Offset: 0x0003F564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376665, XrefRangeEnd = 376671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000413A8 File Offset: 0x0003F5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376671, XrefRangeEnd = 376675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoopback(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000413EC File Offset: 0x0003F5EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376677, RefRangeEnd = 376679, XrefRangeStart = 376675, XrefRangeEnd = 376677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Object comparandObj, bool compareScopeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparandObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareScopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00041448 File Offset: 0x0003F648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376679, XrefRangeEnd = 376680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000414A0 File Offset: 0x0003F6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376680, XrefRangeEnd = 376681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000414E8 File Offset: 0x0003F6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376681, XrefRangeEnd = 376688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress MapToIPv6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0000706D File Offset: 0x0000526D
		public IPAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00041528 File Offset: 0x0003F728
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00007076 File Offset: 0x00005276
		public unsafe static IPAddress Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00041550 File Offset: 0x0003F750
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00007088 File Offset: 0x00005288
		public unsafe static IPAddress Loopback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Loopback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Loopback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00041578 File Offset: 0x0003F778
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x0000709A File Offset: 0x0000529A
		public unsafe static IPAddress Broadcast
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Broadcast, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Broadcast, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000415A0 File Offset: 0x0003F7A0
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x000070AC File Offset: 0x000052AC
		public unsafe static IPAddress None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000415C8 File Offset: 0x0003F7C8
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x000070BE File Offset: 0x000052BE
		public unsafe static long LoopbackMask
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_LoopbackMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_LoopbackMask, (void*)(&value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000415E4 File Offset: 0x0003F7E4
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x000070CC File Offset: 0x000052CC
		public unsafe long m_Address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Address);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Address)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0004160C File Offset: 0x0003F80C
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x000070E7 File Offset: 0x000052E7
		public unsafe string m_ToString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ToString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ToString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00041634 File Offset: 0x0003F834
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00007106 File Offset: 0x00005306
		public unsafe static IPAddress IPv6Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0004165C File Offset: 0x0003F85C
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00007118 File Offset: 0x00005318
		public unsafe static IPAddress IPv6Loopback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6Loopback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6Loopback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00041684 File Offset: 0x0003F884
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0000712A File Offset: 0x0000532A
		public unsafe static IPAddress IPv6None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000416AC File Offset: 0x0003F8AC
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0000713C File Offset: 0x0000533C
		public unsafe AddressFamily m_Family
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Family);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Family)) = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000416D4 File Offset: 0x0003F8D4
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00007157 File Offset: 0x00005357
		public unsafe Il2CppStructArray<ushort> m_Numbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Numbers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Numbers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00041704 File Offset: 0x0003F904
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00007176 File Offset: 0x00005376
		public unsafe long m_ScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ScopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ScopeId)) = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0004172C File Offset: 0x0003F92C
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00007191 File Offset: 0x00005391
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00041754 File Offset: 0x0003F954
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x000071AC File Offset: 0x000053AC
		public unsafe static int IPv4AddressBytes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv4AddressBytes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv4AddressBytes, (void*)(&value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00041770 File Offset: 0x0003F970
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x000071BA File Offset: 0x000053BA
		public unsafe static int IPv6AddressBytes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6AddressBytes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6AddressBytes, (void*)(&value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0004178C File Offset: 0x0003F98C
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x000071C8 File Offset: 0x000053C8
		public unsafe static int NumberOfLabels
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_NumberOfLabels, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_NumberOfLabels, (void*)(&value));
			}
		}

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_Loopback;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_Broadcast;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_LoopbackMask;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr_m_Address;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr_m_ToString;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Any;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Loopback;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr_IPv6None;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeFieldInfoPtr_m_Family;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_m_Numbers;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_m_ScopeId;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_IPv4AddressBytes;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_IPv6AddressBytes;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfLabels;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_InternalParse_Private_Static_IPAddress_String_Boolean_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0;
	}
}
