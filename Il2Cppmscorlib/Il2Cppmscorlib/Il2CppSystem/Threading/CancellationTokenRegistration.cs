using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025B RID: 603
	public sealed class CancellationTokenRegistration : ValueType
	{
		// Token: 0x06002A13 RID: 10771 RVA: 0x000DCE64 File Offset: 0x000DB064
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenRegistration()
		{
			Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationTokenRegistration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr);
			CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, "m_callbackInfo");
			CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, "m_registrationInfo");
			CancellationTokenRegistration.NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100670102);
			CancellationTokenRegistration.NativeMethodInfoPtr_TryDeregister_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100670103);
			CancellationTokenRegistration.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100670104);
			CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100670105);
			CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100670106);
			CancellationTokenRegistration.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100670107);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000DCF34 File Offset: 0x000DB134
		[CallerCount(0)]
		public unsafe CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(registrationInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000DCF9C File Offset: 0x000DB19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200220, RefRangeEnd = 200221, XrefRangeStart = 200216, XrefRangeEnd = 200220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDeregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_TryDeregister_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000DCFE0 File Offset: 0x000DB1E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 200225, RefRangeEnd = 200232, XrefRangeStart = 200221, XrefRangeEnd = 200225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000DD018 File Offset: 0x000DB218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200232, XrefRangeEnd = 200236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000DD06C File Offset: 0x000DB26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200236, XrefRangeEnd = 200238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CancellationTokenRegistration other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000DD0C4 File Offset: 0x000DB2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200238, XrefRangeEnd = 200240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0000E783 File Offset: 0x0000C983
		public CancellationTokenRegistration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0000E78C File Offset: 0x0000C98C
		public CancellationTokenRegistration()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr))
		{
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x000DD108 File Offset: 0x000DB308
		// (set) Token: 0x06002A1D RID: 10781 RVA: 0x0000E79E File Offset: 0x0000C99E
		public unsafe CancellationCallbackInfo m_callbackInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002A1E RID: 10782 RVA: 0x000DD138 File Offset: 0x000DB338
		// (set) Token: 0x06002A1F RID: 10783 RVA: 0x0000E7BD File Offset: 0x0000C9BD
		public SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo);
				return new SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeFieldInfoPtr_m_callbackInfo;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeFieldInfoPtr_m_registrationInfo;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_TryDeregister_Internal_Boolean_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
