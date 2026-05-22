using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200007F RID: 127
	public class DoWorkEventArgs : CancelEventArgs
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x00030610 File Offset: 0x0002E810
		// Note: this type is marked as 'beforefieldinit'.
		static DoWorkEventArgs()
		{
			Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DoWorkEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr);
			DoWorkEventArgs.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr, "result");
			DoWorkEventArgs.NativeFieldInfoPtr_argument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr, "argument");
			DoWorkEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr, 100664517);
			DoWorkEventArgs.NativeMethodInfoPtr_get_Argument_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr, 100664518);
			DoWorkEventArgs.NativeMethodInfoPtr_get_Result_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr, 100664519);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000306A4 File Offset: 0x0002E8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372832, XrefRangeEnd = 372835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoWorkEventArgs(Object argument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoWorkEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoWorkEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x000306F0 File Offset: 0x0002E8F0
		public unsafe Object Argument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoWorkEventArgs.NativeMethodInfoPtr_get_Argument_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00030730 File Offset: 0x0002E930
		public unsafe Object Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoWorkEventArgs.NativeMethodInfoPtr_get_Result_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00005560 File Offset: 0x00003760
		public DoWorkEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00030770 File Offset: 0x0002E970
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00005569 File Offset: 0x00003769
		public unsafe Object result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoWorkEventArgs.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoWorkEventArgs.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000307A0 File Offset: 0x0002E9A0
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00005588 File Offset: 0x00003788
		public unsafe Object argument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoWorkEventArgs.NativeFieldInfoPtr_argument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoWorkEventArgs.NativeFieldInfoPtr_argument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_argument;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_get_Argument_Public_get_Object_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Object_0;
	}
}
