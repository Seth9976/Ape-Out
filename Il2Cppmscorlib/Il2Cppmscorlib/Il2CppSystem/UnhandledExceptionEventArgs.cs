using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000100 RID: 256
	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x0007C374 File Offset: 0x0007A574
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionEventArgs()
		{
			Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnhandledExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr);
			UnhandledExceptionEventArgs.NativeFieldInfoPtr__Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, "_Exception");
			UnhandledExceptionEventArgs.NativeFieldInfoPtr__IsTerminating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, "_IsTerminating");
			UnhandledExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666652);
			UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666653);
			UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666654);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0007C408 File Offset: 0x0007A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173157, XrefRangeEnd = 173160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnhandledExceptionEventArgs(Object exception, bool isTerminating)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTerminating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0007C464 File Offset: 0x0007A664
		public unsafe Object ExceptionObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0007C4A4 File Offset: 0x0007A6A4
		public unsafe bool IsTerminating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000065E5 File Offset: 0x000047E5
		public UnhandledExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0007C4E0 File Offset: 0x0007A6E0
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x000065EE File Offset: 0x000047EE
		public unsafe Object _Exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__Exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0007C510 File Offset: 0x0007A710
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x0000660D File Offset: 0x0000480D
		public unsafe bool _IsTerminating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__IsTerminating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__IsTerminating)) = value;
			}
		}

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr__Exception;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr__IsTerminating;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0;
	}
}
