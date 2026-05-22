using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000269 RID: 617
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		// Token: 0x06002B1A RID: 11034 RVA: 0x000E05E8 File Offset: 0x000DE7E8
		// Note: this type is marked as 'beforefieldinit'.
		static AbandonedMutexException()
		{
			Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AbandonedMutexException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr);
			AbandonedMutexException.NativeFieldInfoPtr_m_MutexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, "m_MutexIndex");
			AbandonedMutexException.NativeFieldInfoPtr_m_Mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, "m_Mutex");
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670218);
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670219);
			AbandonedMutexException.NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670220);
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670221);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000E0690 File Offset: 0x000DE890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200984, RefRangeEnd = 200985, XrefRangeStart = 200981, XrefRangeEnd = 200984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000E06CC File Offset: 0x000DE8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200990, RefRangeEnd = 200991, XrefRangeStart = 200985, XrefRangeEnd = 200990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException(int location, WaitHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000E0728 File Offset: 0x000DE928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200991, XrefRangeEnd = 200993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupException(int location, WaitHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000E0778 File Offset: 0x000DE978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200993, XrefRangeEnd = 200997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0000EE03 File Offset: 0x0000D003
		public AbandonedMutexException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000E07DC File Offset: 0x000DE9DC
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x0000EE0C File Offset: 0x0000D00C
		public unsafe int m_MutexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_MutexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_MutexIndex)) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000E0804 File Offset: 0x000DEA04
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x0000EE27 File Offset: 0x0000D027
		public unsafe Mutex m_Mutex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_Mutex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mutex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_Mutex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeFieldInfoPtr_m_MutexIndex;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeFieldInfoPtr_m_Mutex;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
