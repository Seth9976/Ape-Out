using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000319 RID: 793
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x06003492 RID: 13458 RVA: 0x00103D34 File Offset: 0x00101F34
		// Note: this type is marked as 'beforefieldinit'.
		static RNGCryptoServiceProvider()
		{
			Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RNGCryptoServiceProvider");
			RNGCryptoServiceProvider.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, "_lock");
			RNGCryptoServiceProvider.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, "_handle");
			RNGCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671503);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671504);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671505);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671506);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671507);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671508);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671509);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671510);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671511);
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00103E38 File Offset: 0x00102038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212733, XrefRangeEnd = 212738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RNGCryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00103E74 File Offset: 0x00102074
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212739, RefRangeEnd = 212743, XrefRangeStart = 212738, XrefRangeEnd = 212739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00103EA8 File Offset: 0x001020A8
		[CallerCount(0)]
		public unsafe static bool RngOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00103ED8 File Offset: 0x001020D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212743, XrefRangeEnd = 212744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr RngInitialize(Il2CppStructArray<byte> seed)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00103F1C File Offset: 0x0010211C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212745, RefRangeEnd = 212747, XrefRangeStart = 212744, XrefRangeEnd = 212745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr RngGetBytes(IntPtr handle, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00103F6C File Offset: 0x0010216C
		[CallerCount(0)]
		public unsafe static void RngClose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00103FA0 File Offset: 0x001021A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212747, XrefRangeEnd = 212778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetBytes(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00103FE4 File Offset: 0x001021E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212778, XrefRangeEnd = 212783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00104018 File Offset: 0x00102218
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x0001292F File Offset: 0x00010B2F
		public RNGCryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x00104058 File Offset: 0x00102258
		// (set) Token: 0x0600349E RID: 13470 RVA: 0x00012938 File Offset: 0x00010B38
		public unsafe static Object _lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RNGCryptoServiceProvider.NativeFieldInfoPtr__lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RNGCryptoServiceProvider.NativeFieldInfoPtr__lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x00104080 File Offset: 0x00102280
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x0001294A File Offset: 0x00010B4A
		public unsafe IntPtr _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RNGCryptoServiceProvider.NativeFieldInfoPtr__handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RNGCryptoServiceProvider.NativeFieldInfoPtr__handle)) = value;
			}
		}

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeMethodInfoPtr_Check_Private_Void_0;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
