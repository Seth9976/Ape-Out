using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025A RID: 602
	public sealed class CancellationToken : ValueType
	{
		// Token: 0x060029FB RID: 10747 RVA: 0x000DC778 File Offset: 0x000DA978
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationToken()
		{
			Il2CppClassPointerStore<CancellationToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr);
			CancellationToken.NativeFieldInfoPtr_m_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "m_source");
			CancellationToken.NativeFieldInfoPtr_s_ActionToActionObjShunt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "s_ActionToActionObjShunt");
			CancellationToken.NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670084);
			CancellationToken.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670085);
			CancellationToken.NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670086);
			CancellationToken.NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670087);
			CancellationToken.NativeMethodInfoPtr_ActionToActionObjShunt_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670088);
			CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670089);
			CancellationToken.NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670090);
			CancellationToken.NativeMethodInfoPtr_Register_Private_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670091);
			CancellationToken.NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670092);
			CancellationToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670093);
			CancellationToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670094);
			CancellationToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670095);
			CancellationToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670096);
			CancellationToken.NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670097);
			CancellationToken.NativeMethodInfoPtr_ThrowIfSourceDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670098);
			CancellationToken.NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670099);
			CancellationToken.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100670100);
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000DC924 File Offset: 0x000DAB24
		public unsafe static CancellationToken None
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x000DC950 File Offset: 0x000DAB50
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000DC994 File Offset: 0x000DAB94
		public unsafe bool CanBeCanceled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200137, RefRangeEnd = 200138, XrefRangeStart = 200137, XrefRangeEnd = 200137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x000DC9D8 File Offset: 0x000DABD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationToken(CancellationTokenSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x000DCA28 File Offset: 0x000DAC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200138, XrefRangeEnd = 200142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActionToActionObjShunt(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ActionToActionObjShunt_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000DCA60 File Offset: 0x000DAC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200142, XrefRangeEnd = 200147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationTokenRegistration(intPtr);
			}
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x000DCAB0 File Offset: 0x000DACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200147, XrefRangeEnd = 200148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x000DCB10 File Offset: 0x000DAD10
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 200154, RefRangeEnd = 200165, XrefRangeStart = 200148, XrefRangeEnd = 200154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action<Object> callback, Object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSynchronizationContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Private_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x000DCB8C File Offset: 0x000DAD8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 200173, RefRangeEnd = 200179, XrefRangeStart = 200165, XrefRangeEnd = 200173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CancellationToken other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000DCBE4 File Offset: 0x000DADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200179, XrefRangeEnd = 200182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x000DCC38 File Offset: 0x000DAE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200182, XrefRangeEnd = 200191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000DCC7C File Offset: 0x000DAE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200191, XrefRangeEnd = 200192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CancellationToken left, CancellationToken right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x000DCCDC File Offset: 0x000DAEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200192, XrefRangeEnd = 200193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CancellationToken left, CancellationToken right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000DCD3C File Offset: 0x000DAF3C
		[CallerCount(0)]
		public unsafe void ThrowIfCancellationRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000DCD74 File Offset: 0x000DAF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200193, XrefRangeEnd = 200194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfSourceDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowIfSourceDisposed_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000DCDAC File Offset: 0x000DAFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200194, XrefRangeEnd = 200201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOperationCanceledException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000DCDE4 File Offset: 0x000DAFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200201, XrefRangeEnd = 200216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowObjectDisposedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0000E737 File Offset: 0x0000C937
		public CancellationToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0000E740 File Offset: 0x0000C940
		public CancellationToken()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000DCE0C File Offset: 0x000DB00C
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0000E752 File Offset: 0x0000C952
		public unsafe CancellationTokenSource m_source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationToken.NativeFieldInfoPtr_m_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationToken.NativeFieldInfoPtr_m_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000DCE3C File Offset: 0x000DB03C
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0000E771 File Offset: 0x0000C971
		public unsafe static Action<Object> s_ActionToActionObjShunt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationToken.NativeFieldInfoPtr_s_ActionToActionObjShunt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationToken.NativeFieldInfoPtr_s_ActionToActionObjShunt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeFieldInfoPtr_m_source;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeFieldInfoPtr_s_ActionToActionObjShunt;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_ActionToActionObjShunt_Private_Static_Void_Object_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_Register_Private_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfSourceDisposed_Internal_Void_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0;
	}
}
