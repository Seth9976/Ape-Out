using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002BC RID: 700
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		// Token: 0x06002FC3 RID: 12227 RVA: 0x000F2954 File Offset: 0x000F0B54
		// Note: this type is marked as 'beforefieldinit'.
		static UnobservedTaskExceptionEventArgs()
		{
			Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnobservedTaskExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr);
			UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_exception");
			UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_observed");
			UnobservedTaskExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, 100670905);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000F29C0 File Offset: 0x000F0BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207506, XrefRangeEnd = 207509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnobservedTaskExceptionEventArgs(AggregateException exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnobservedTaskExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00010887 File Offset: 0x0000EA87
		public UnobservedTaskExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x000F2A0C File Offset: 0x000F0C0C
		// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00010890 File Offset: 0x0000EA90
		public unsafe AggregateException m_exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x000F2A3C File Offset: 0x000F0C3C
		// (set) Token: 0x06002FC9 RID: 12233 RVA: 0x000108AF File Offset: 0x0000EAAF
		public unsafe bool m_observed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed)) = value;
			}
		}

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeFieldInfoPtr_m_exception;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeFieldInfoPtr_m_observed;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0;
	}
}
