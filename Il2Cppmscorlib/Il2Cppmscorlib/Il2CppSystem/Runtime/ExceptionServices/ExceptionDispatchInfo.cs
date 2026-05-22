using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x0200040E RID: 1038
	public sealed class ExceptionDispatchInfo : Object
	{
		// Token: 0x0600426F RID: 17007 RVA: 0x00134E2C File Offset: 0x0013302C
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionDispatchInfo()
		{
			Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "ExceptionDispatchInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr);
			ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_Exception");
			ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_stackTrace");
			ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100673021);
			ExceptionDispatchInfo.NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100673022);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100673023);
			ExceptionDispatchInfo.NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100673024);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100673025);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00134EE8 File Offset: 0x001330E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 225800, RefRangeEnd = 225812, XrefRangeStart = 225789, XrefRangeEnd = 225800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo(Exception exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x00134F34 File Offset: 0x00133134
		public unsafe Object BinaryStackTraceArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00134F74 File Offset: 0x00133174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225812, XrefRangeEnd = 225816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExceptionDispatchInfo Capture(Exception source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x00134FB8 File Offset: 0x001331B8
		public unsafe Exception SourceException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00134FF8 File Offset: 0x001331F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 225822, RefRangeEnd = 225826, XrefRangeStart = 225816, XrefRangeEnd = 225822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00019139 File Offset: 0x00017339
		public ExceptionDispatchInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x0013502C File Offset: 0x0013322C
		// (set) Token: 0x06004277 RID: 17015 RVA: 0x00019142 File Offset: 0x00017342
		public unsafe Exception m_Exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x0013505C File Offset: 0x0013325C
		// (set) Token: 0x06004279 RID: 17017 RVA: 0x00019161 File Offset: 0x00017361
		public unsafe Object m_stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400362E RID: 13870
		private static readonly IntPtr NativeFieldInfoPtr_m_Exception;

		// Token: 0x0400362F RID: 13871
		private static readonly IntPtr NativeFieldInfoPtr_m_stackTrace;

		// Token: 0x04003630 RID: 13872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Exception_0;

		// Token: 0x04003631 RID: 13873
		private static readonly IntPtr NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0;

		// Token: 0x04003632 RID: 13874
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0;

		// Token: 0x04003633 RID: 13875
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0;

		// Token: 0x04003634 RID: 13876
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Void_0;
	}
}
