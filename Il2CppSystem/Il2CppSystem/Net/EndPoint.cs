using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E2 RID: 226
	[Serializable]
	public class EndPoint : Object
	{
		// Token: 0x06000CAB RID: 3243 RVA: 0x000407FC File Offset: 0x0003E9FC
		// Note: this type is marked as 'beforefieldinit'.
		static EndPoint()
		{
			Il2CppClassPointerStore<EndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPoint>.NativeClassPtr);
			EndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100665151);
			EndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100665152);
			EndPoint.NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100665153);
			EndPoint.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100665154);
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0004087C File Offset: 0x0003EA7C
		public unsafe virtual AddressFamily AddressFamily
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376596, XrefRangeEnd = 376599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000408C4 File Offset: 0x0003EAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376599, XrefRangeEnd = 376602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SocketAddress Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00040910 File Offset: 0x0003EB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376602, XrefRangeEnd = 376605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EndPoint Create(SocketAddress socketAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socketAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0004096C File Offset: 0x0003EB6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndPoint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPoint.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00006FB5 File Offset: 0x000051B5
		public EndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
