using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000091 RID: 145
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008DC RID: 2268 RVA: 0x00031A10 File Offset: 0x0002FC10
		// Note: this type is marked as 'beforefieldinit'.
		static RunWorkerCompletedEventArgs()
		{
			Il2CppClassPointerStore<RunWorkerCompletedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "RunWorkerCompletedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunWorkerCompletedEventArgs>.NativeClassPtr);
			RunWorkerCompletedEventArgs.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunWorkerCompletedEventArgs>.NativeClassPtr, "result");
			RunWorkerCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunWorkerCompletedEventArgs>.NativeClassPtr, 100664558);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00031A68 File Offset: 0x0002FC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372852, XrefRangeEnd = 372853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunWorkerCompletedEventArgs(Object result, Exception error, bool cancelled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunWorkerCompletedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cancelled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunWorkerCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000058D7 File Offset: 0x00003AD7
		public RunWorkerCompletedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00031AD4 File Offset: 0x0002FCD4
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x000058E0 File Offset: 0x00003AE0
		public unsafe Object result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWorkerCompletedEventArgs.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunWorkerCompletedEventArgs.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Exception_Boolean_0;
	}
}
