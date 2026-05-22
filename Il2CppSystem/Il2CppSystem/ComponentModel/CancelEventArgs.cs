using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000071 RID: 113
	public class CancelEventArgs : EventArgs
	{
		// Token: 0x060007ED RID: 2029 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		// Note: this type is marked as 'beforefieldinit'.
		static CancelEventArgs()
		{
			Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CancelEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr);
			CancelEventArgs.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr, "cancel");
			CancelEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr, 100664456);
			CancelEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr, 100664457);
			CancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr, 100664458);
			CancelEventArgs.NativeMethodInfoPtr_set_Cancel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr, 100664459);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372696, XrefRangeEnd = 372699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancelEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancelEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372699, XrefRangeEnd = 372702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancelEventArgs(bool cancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancelEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0002EC44 File Offset: 0x0002CE44
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0002EC80 File Offset: 0x0002CE80
		public unsafe bool Cancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancelEventArgs.NativeMethodInfoPtr_set_Cancel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000051E1 File Offset: 0x000033E1
		public CancelEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x000051EA File Offset: 0x000033EA
		public unsafe bool cancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancelEventArgs.NativeFieldInfoPtr_cancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancelEventArgs.NativeFieldInfoPtr_cancel)) = value;
			}
		}

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr_cancel;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_set_Cancel_Public_set_Void_Boolean_0;
	}
}
