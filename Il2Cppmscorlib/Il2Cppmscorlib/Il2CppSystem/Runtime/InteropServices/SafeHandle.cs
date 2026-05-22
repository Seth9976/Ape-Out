using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000458 RID: 1112
	public class SafeHandle : CriticalFinalizerObject
	{
		// Token: 0x06004422 RID: 17442 RVA: 0x0013A3E0 File Offset: 0x001385E0
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandle()
		{
			Il2CppClassPointerStore<SafeHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr);
			SafeHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "handle");
			SafeHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_state");
			SafeHandle.NativeFieldInfoPtr__ownsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_ownsHandle");
			SafeHandle.NativeFieldInfoPtr__fullyInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_fullyInitialized");
			SafeHandle.NativeFieldInfoPtr_RefCount_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "RefCount_Mask");
			SafeHandle.NativeFieldInfoPtr_RefCount_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "RefCount_One");
			SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673205);
			SafeHandle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673206);
			SafeHandle.NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673207);
			SafeHandle.NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673208);
			SafeHandle.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673209);
			SafeHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673210);
			SafeHandle.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673211);
			SafeHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673212);
			SafeHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673213);
			SafeHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673214);
			SafeHandle.NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673215);
			SafeHandle.NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673216);
			SafeHandle.NativeMethodInfoPtr_DangerousRelease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673217);
			SafeHandle.NativeMethodInfoPtr_InternalDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673218);
			SafeHandle.NativeMethodInfoPtr_InternalFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673219);
			SafeHandle.NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100673220);
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x0013A5C8 File Offset: 0x001387C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 226866, RefRangeEnd = 226872, XrefRangeStart = 226862, XrefRangeEnd = 226866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invalidHandleValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x0013A620 File Offset: 0x00138820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226872, XrefRangeEnd = 226875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x0013A65C File Offset: 0x0013885C
		[CallerCount(0)]
		public unsafe void SetHandle(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x0013A69C File Offset: 0x0013889C
		[CallerCount(0)]
		public unsafe IntPtr DangerousGetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06004427 RID: 17447 RVA: 0x0013A6D8 File Offset: 0x001388D8
		public unsafe bool IsClosed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x0013A714 File Offset: 0x00138914
		public unsafe virtual bool IsInvalid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x0013A75C File Offset: 0x0013895C
		[CallerCount(0)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x0013A790 File Offset: 0x00138990
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x0013A7C4 File Offset: 0x001389C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226875, XrefRangeEnd = 226876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x0013A810 File Offset: 0x00138A10
		[CallerCount(0)]
		public unsafe virtual bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x0013A858 File Offset: 0x00138A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226880, RefRangeEnd = 226881, XrefRangeStart = 226876, XrefRangeEnd = 226880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandleAsInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x0013A88C File Offset: 0x00138A8C
		[CallerCount(344)]
		[CachedScanResults(RefRangeStart = 226881, RefRangeEnd = 227225, XrefRangeStart = 226881, XrefRangeEnd = 226881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousAddRef(ref bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x0013A8CC File Offset: 0x00138ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227225, XrefRangeEnd = 227226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousRelease()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousRelease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0013A900 File Offset: 0x00138B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227226, XrefRangeEnd = 227236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_InternalDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x0013A934 File Offset: 0x00138B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227236, XrefRangeEnd = 227237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_InternalFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x0013A968 File Offset: 0x00138B68
		[CallerCount(349)]
		[CachedScanResults(RefRangeStart = 227238, RefRangeEnd = 227587, XrefRangeStart = 227237, XrefRangeEnd = 227238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousReleaseInternal(bool dispose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dispose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00019FE3 File Offset: 0x000181E3
		public SafeHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x0013A9A8 File Offset: 0x00138BA8
		// (set) Token: 0x06004435 RID: 17461 RVA: 0x00019FEC File Offset: 0x000181EC
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x0013A9D0 File Offset: 0x00138BD0
		// (set) Token: 0x06004437 RID: 17463 RVA: 0x0001A007 File Offset: 0x00018207
		public unsafe int _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x0013A9F8 File Offset: 0x00138BF8
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x0001A022 File Offset: 0x00018222
		public unsafe bool _ownsHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__ownsHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__ownsHandle)) = value;
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x0013AA20 File Offset: 0x00138C20
		// (set) Token: 0x0600443B RID: 17467 RVA: 0x0001A03D File Offset: 0x0001823D
		public unsafe bool _fullyInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__fullyInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__fullyInitialized)) = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x0013AA48 File Offset: 0x00138C48
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x0001A058 File Offset: 0x00018258
		public unsafe static int RefCount_Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeHandle.NativeFieldInfoPtr_RefCount_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeHandle.NativeFieldInfoPtr_RefCount_Mask, (void*)(&value));
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x0013AA64 File Offset: 0x00138C64
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x0001A066 File Offset: 0x00018266
		public unsafe static int RefCount_One
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeHandle.NativeFieldInfoPtr_RefCount_One, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeHandle.NativeFieldInfoPtr_RefCount_One, (void*)(&value));
			}
		}

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeFieldInfoPtr__ownsHandle;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeFieldInfoPtr__fullyInitialized;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeFieldInfoPtr_RefCount_Mask;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeFieldInfoPtr_RefCount_One;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr_DangerousRelease_Public_Void_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr_InternalDispose_Private_Void_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr_InternalFinalize_Private_Void_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0;
	}
}
