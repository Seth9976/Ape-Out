using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000141 RID: 321
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x0005D570 File Offset: 0x0005B770
		// Note: this type is marked as 'beforefieldinit'.
		static SocketException()
		{
			Il2CppClassPointerStore<SocketException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketException>.NativeClassPtr);
			SocketException.NativeFieldInfoPtr_m_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketException>.NativeClassPtr, "m_EndPoint");
			SocketException.NativeMethodInfoPtr_WSAGetLastError_internal_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666215);
			SocketException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666216);
			SocketException.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666217);
			SocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666218);
			SocketException.NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666219);
			SocketException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666220);
			SocketException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666221);
			SocketException.NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100666222);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0005D654 File Offset: 0x0005B854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386538, XrefRangeEnd = 386539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WSAGetLastError_internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr_WSAGetLastError_internal_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0005D684 File Offset: 0x0005B884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386539, XrefRangeEnd = 386544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0005D6C0 File Offset: 0x0005B8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 386548, RefRangeEnd = 386549, XrefRangeStart = 386544, XrefRangeEnd = 386548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(int error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0005D71C File Offset: 0x0005B91C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 386553, RefRangeEnd = 386558, XrefRangeStart = 386549, XrefRangeEnd = 386553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(int errorCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0005D764 File Offset: 0x0005B964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386558, XrefRangeEnd = 386562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(SocketError socketError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socketError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0005D7AC File Offset: 0x0005B9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386562, XrefRangeEnd = 386572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0005D810 File Offset: 0x0005BA10
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386572, XrefRangeEnd = 386578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005D854 File Offset: 0x0005BA54
		public unsafe SocketError SocketErrorCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0000A65B File Offset: 0x0000885B
		public SocketException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0005D890 File Offset: 0x0005BA90
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000A664 File Offset: 0x00008864
		public unsafe EndPoint m_EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketException.NativeFieldInfoPtr_m_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketException.NativeFieldInfoPtr_m_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeFieldInfoPtr_m_EndPoint;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_WSAGetLastError_internal_Private_Static_Int32_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0;
	}
}
