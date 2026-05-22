using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;

namespace Il2CppSanford.Threading
{
	// Token: 0x0200017F RID: 383
	public class InvokeCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001113 RID: 4371 RVA: 0x0005313C File Offset: 0x0005133C
		// Note: this type is marked as 'beforefieldinit'.
		static InvokeCompletedEventArgs()
		{
			Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Threading", "InvokeCompletedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr);
			InvokeCompletedEventArgs.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, "method");
			InvokeCompletedEventArgs.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, "args");
			InvokeCompletedEventArgs.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, "result");
			InvokeCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Il2CppReferenceArray_1_Object_Object_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, 100665787);
			InvokeCompletedEventArgs.NativeMethodInfoPtr_GetArgs_Public_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, 100665788);
			InvokeCompletedEventArgs.NativeMethodInfoPtr_get_Method_Public_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, 100665789);
			InvokeCompletedEventArgs.NativeMethodInfoPtr_get_Result_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr, 100665790);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000531F8 File Offset: 0x000513F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14072, RefRangeEnd = 14075, XrefRangeStart = 14071, XrefRangeEnd = 14072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokeCompletedEventArgs(Delegate method, Il2CppReferenceArray<Object> args, Object result, Exception error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokeCompletedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeCompletedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Il2CppReferenceArray_1_Object_Object_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0005327C File Offset: 0x0005147C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeCompletedEventArgs.NativeMethodInfoPtr_GetArgs_Public_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x000532BC File Offset: 0x000514BC
		public unsafe Delegate Method
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeCompletedEventArgs.NativeMethodInfoPtr_get_Method_Public_get_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x000532FC File Offset: 0x000514FC
		public unsafe Object Result
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeCompletedEventArgs.NativeMethodInfoPtr_get_Result_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00007047 File Offset: 0x00005247
		public InvokeCompletedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0005333C File Offset: 0x0005153C
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x00007050 File Offset: 0x00005250
		public unsafe Delegate method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeCompletedEventArgs.NativeFieldInfoPtr_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeCompletedEventArgs.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0005336C File Offset: 0x0005156C
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0000706F File Offset: 0x0000526F
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeCompletedEventArgs.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeCompletedEventArgs.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0005339C File Offset: 0x0005159C
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000708E File Offset: 0x0000528E
		public unsafe Object result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeCompletedEventArgs.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeCompletedEventArgs.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_Il2CppReferenceArray_1_Object_Object_Exception_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Public_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_Delegate_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Object_0;
	}
}
