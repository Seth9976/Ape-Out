using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Threading;

namespace Il2CppSanford.Threading
{
	// Token: 0x0200017C RID: 380
	public class PostCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010C6 RID: 4294 RVA: 0x00051FCC File Offset: 0x000501CC
		// Note: this type is marked as 'beforefieldinit'.
		static PostCompletedEventArgs()
		{
			Il2CppClassPointerStore<PostCompletedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Threading", "PostCompletedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostCompletedEventArgs>.NativeClassPtr);
			PostCompletedEventArgs.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostCompletedEventArgs>.NativeClassPtr, "callback");
			PostCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostCompletedEventArgs>.NativeClassPtr, 100665751);
			PostCompletedEventArgs.NativeMethodInfoPtr_get_Callback_Public_get_SendOrPostCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostCompletedEventArgs>.NativeClassPtr, 100665752);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00052038 File Offset: 0x00050238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13862, XrefRangeEnd = 13863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostCompletedEventArgs(SendOrPostCallback callback, Exception error, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostCompletedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x000520A8 File Offset: 0x000502A8
		public unsafe SendOrPostCallback Callback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostCompletedEventArgs.NativeMethodInfoPtr_get_Callback_Public_get_SendOrPostCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr3) : null;
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00006E41 File Offset: 0x00005041
		public PostCompletedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x000520E8 File Offset: 0x000502E8
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x00006E4A File Offset: 0x0000504A
		public unsafe SendOrPostCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostCompletedEventArgs.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostCompletedEventArgs.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Exception_Object_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_get_Callback_Public_get_SendOrPostCallback_0;
	}
}
