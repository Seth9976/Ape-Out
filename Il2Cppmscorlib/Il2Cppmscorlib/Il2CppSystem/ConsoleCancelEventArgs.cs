using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200008A RID: 138
	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs
	{
		// Token: 0x060008A5 RID: 2213 RVA: 0x0004A488 File Offset: 0x00048688
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleCancelEventArgs()
		{
			Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleCancelEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr);
			ConsoleCancelEventArgs.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "_type");
			ConsoleCancelEventArgs.NativeFieldInfoPtr__cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "_cancel");
			ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100664693);
			ConsoleCancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100664694);
			ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100664695);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0004A51C File Offset: 0x0004871C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150202, XrefRangeEnd = 150205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventArgs(ConsoleSpecialKey type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0004A564 File Offset: 0x00048764
		public unsafe bool Cancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0004A5A0 File Offset: 0x000487A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150205, XrefRangeEnd = 150217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000048B3 File Offset: 0x00002AB3
		public ConsoleCancelEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0004A5DC File Offset: 0x000487DC
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x000048BC File Offset: 0x00002ABC
		public unsafe ConsoleSpecialKey _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0004A604 File Offset: 0x00048804
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x000048D7 File Offset: 0x00002AD7
		public unsafe bool _cancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__cancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleCancelEventArgs.NativeFieldInfoPtr__cancel)) = value;
			}
		}

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr__cancel;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
