using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006B RID: 107
	public class AsyncCompletedEventArgs : EventArgs
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncCompletedEventArgs()
		{
			Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AsyncCompletedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr);
			AsyncCompletedEventArgs.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr, "error");
			AsyncCompletedEventArgs.NativeFieldInfoPtr_cancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr, "cancelled");
			AsyncCompletedEventArgs.NativeFieldInfoPtr_userState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr, "userState");
			AsyncCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr, 100664410);
			AsyncCompletedEventArgs.NativeMethodInfoPtr_get_Cancelled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr, 100664411);
			AsyncCompletedEventArgs.NativeMethodInfoPtr_get_Error_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr, 100664412);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0002D778 File Offset: 0x0002B978
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 372477, RefRangeEnd = 372484, XrefRangeStart = 372474, XrefRangeEnd = 372477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncCompletedEventArgs(Exception error, bool cancelled, Object userState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncCompletedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cancelled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
		public unsafe bool Cancelled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCompletedEventArgs.NativeMethodInfoPtr_get_Cancelled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0002D820 File Offset: 0x0002BA20
		public unsafe Exception Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCompletedEventArgs.NativeMethodInfoPtr_get_Error_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00004F78 File Offset: 0x00003178
		public AsyncCompletedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0002D860 File Offset: 0x0002BA60
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00004F81 File Offset: 0x00003181
		public unsafe Exception error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncCompletedEventArgs.NativeFieldInfoPtr_error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncCompletedEventArgs.NativeFieldInfoPtr_error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0002D890 File Offset: 0x0002BA90
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00004FA0 File Offset: 0x000031A0
		public unsafe bool cancelled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncCompletedEventArgs.NativeFieldInfoPtr_cancelled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncCompletedEventArgs.NativeFieldInfoPtr_cancelled)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00004FBB File Offset: 0x000031BB
		public unsafe Object userState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncCompletedEventArgs.NativeFieldInfoPtr_userState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncCompletedEventArgs.NativeFieldInfoPtr_userState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_cancelled;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_userState;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_Object_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancelled_Public_get_Boolean_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_Exception_0;
	}
}
