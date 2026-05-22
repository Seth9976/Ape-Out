using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200005E RID: 94
	[Serializable]
	public class AggregateException : Exception
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x0003EFDC File Offset: 0x0003D1DC
		// Note: this type is marked as 'beforefieldinit'.
		static AggregateException()
		{
			Il2CppClassPointerStore<AggregateException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AggregateException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggregateException>.NativeClassPtr);
			AggregateException.NativeFieldInfoPtr_m_innerExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, "m_innerExceptions");
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664314);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664315);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664316);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664317);
			AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664318);
			AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664319);
			AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664320);
			AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664321);
			AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664322);
			AggregateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664323);
			AggregateException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664324);
			AggregateException.NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664325);
			AggregateException.NativeMethodInfoPtr_Flatten_Public_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664326);
			AggregateException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664327);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0003F138 File Offset: 0x0003D338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146609, XrefRangeEnd = 146622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0003F174 File Offset: 0x0003D374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146622, XrefRangeEnd = 146636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(IEnumerable<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146639, RefRangeEnd = 146640, XrefRangeStart = 146636, XrefRangeEnd = 146639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException([Optional] Il2CppReferenceArray<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				innerExceptions = new Il2CppReferenceArray<Exception>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0003F218 File Offset: 0x0003D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146640, XrefRangeEnd = 146652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IEnumerable<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0003F278 File Offset: 0x0003D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146652, XrefRangeEnd = 146653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, [Optional] Il2CppReferenceArray<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				innerExceptions = new Il2CppReferenceArray<Exception>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0003F2E4 File Offset: 0x0003D4E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 146695, RefRangeEnd = 146701, XrefRangeStart = 146653, XrefRangeEnd = 146695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IList<Exception> innerExceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0003F344 File Offset: 0x0003D544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146701, XrefRangeEnd = 146715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0003F390 File Offset: 0x0003D590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146727, RefRangeEnd = 146728, XrefRangeStart = 146715, XrefRangeEnd = 146727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0003F3F0 File Offset: 0x0003D5F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146772, RefRangeEnd = 146774, XrefRangeStart = 146728, XrefRangeEnd = 146772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerExceptionInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0003F450 File Offset: 0x0003D650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146774, XrefRangeEnd = 146809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0003F4B4 File Offset: 0x0003D6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146809, XrefRangeEnd = 146828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0003F518 File Offset: 0x0003D718
		public unsafe ReadOnlyCollection<Exception> InnerExceptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr3) : null;
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0003F558 File Offset: 0x0003D758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146862, RefRangeEnd = 146864, XrefRangeStart = 146828, XrefRangeEnd = 146862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException Flatten()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateException.NativeMethodInfoPtr_Flatten_Public_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0003F598 File Offset: 0x0003D798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146864, XrefRangeEnd = 146901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AggregateException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00003FC5 File Offset: 0x000021C5
		public AggregateException(params Exception[] innerExceptions)
			: this(new Il2CppReferenceArray<Exception>(innerExceptions))
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00003FD3 File Offset: 0x000021D3
		public AggregateException(string message, params Exception[] innerExceptions)
			: this(message, new Il2CppReferenceArray<Exception>(innerExceptions))
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00003FE2 File Offset: 0x000021E2
		public AggregateException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0003F5DC File Offset: 0x0003D7DC
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00003FEB File Offset: 0x000021EB
		public unsafe ReadOnlyCollection<Exception> m_innerExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateException.NativeFieldInfoPtr_m_innerExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateException.NativeFieldInfoPtr_m_innerExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_m_innerExceptions;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_Flatten_Public_AggregateException_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
