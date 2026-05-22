using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000113 RID: 275
	public sealed class DictationRecognizer : Object
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x00059C14 File Offset: 0x00057E14
		// Note: this type is marked as 'beforefieldinit'.
		static DictationRecognizer()
		{
			Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "DictationRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr);
			DictationRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "m_Recognizer");
			DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesis");
			DictationRecognizer.NativeFieldInfoPtr_DictationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResult");
			DictationRecognizer.NativeFieldInfoPtr_DictationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationComplete");
			DictationRecognizer.NativeFieldInfoPtr_DictationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationError");
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100665365);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100665366);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100665367);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100665368);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00059CF8 File Offset: 0x00057EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500413, XrefRangeEnd = 500414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00059D3C File Offset: 0x00057F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500414, XrefRangeEnd = 500415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumConfidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00059D8C File Offset: 0x00057F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500415, XrefRangeEnd = 500416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cause;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00059DCC File Offset: 0x00057FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500416, XrefRangeEnd = 500417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0000C63A File Offset: 0x0000A83A
		public DictationRecognizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00059E1C File Offset: 0x0005801C
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x0000C643 File Offset: 0x0000A843
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00059E44 File Offset: 0x00058044
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000C65E File Offset: 0x0000A85E
		public unsafe DictationRecognizer.DictationHypothesisDelegate DictationHypothesis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationHypothesisDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00059E74 File Offset: 0x00058074
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000C67D File Offset: 0x0000A87D
		public unsafe DictationRecognizer.DictationResultDelegate DictationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationResultDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00059EA4 File Offset: 0x000580A4
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0000C69C File Offset: 0x0000A89C
		public unsafe DictationRecognizer.DictationCompletedDelegate DictationComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationCompletedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00059ED4 File Offset: 0x000580D4
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public unsafe DictationRecognizer.DictationErrorHandler DictationError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationErrorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_DictationHypothesis;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_DictationResult;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr_DictationComplete;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_DictationError;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0;

		// Token: 0x02000893 RID: 2195
		public sealed class DictationHypothesisDelegate : MulticastDelegate
		{
			// Token: 0x06002F43 RID: 12099 RVA: 0x0007D03C File Offset: 0x0007B23C
			// Note: this type is marked as 'beforefieldinit'.
			static DictationHypothesisDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesisDelegate");
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100665369);
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100665370);
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100665371);
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100665372);
			}

			// Token: 0x06002F44 RID: 12100 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationHypothesisDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F45 RID: 12101 RVA: 0x0007D10C File Offset: 0x0007B30C
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F46 RID: 12102 RVA: 0x0007D150 File Offset: 0x0007B350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F47 RID: 12103 RVA: 0x0007D1C4 File Offset: 0x0007B3C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F48 RID: 12104 RVA: 0x000139C4 File Offset: 0x00011BC4
			public DictationHypothesisDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F49 RID: 12105 RVA: 0x000139CD File Offset: 0x00011BCD
			public static implicit operator DictationRecognizer.DictationHypothesisDelegate(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationHypothesisDelegate>(A_0);
			}

			// Token: 0x06002F4A RID: 12106 RVA: 0x000139D5 File Offset: 0x00011BD5
			public static DictationRecognizer.DictationHypothesisDelegate operator +(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationHypothesisDelegate>();
			}

			// Token: 0x06002F4B RID: 12107 RVA: 0x000139E3 File Offset: 0x00011BE3
			public static DictationRecognizer.DictationHypothesisDelegate operator -(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationHypothesisDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001F58 RID: 8024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F59 RID: 8025
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x04001F5A RID: 8026
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04001F5B RID: 8027
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000894 RID: 2196
		public sealed class DictationResultDelegate : MulticastDelegate
		{
			// Token: 0x06002F4C RID: 12108 RVA: 0x0007D208 File Offset: 0x0007B408
			// Note: this type is marked as 'beforefieldinit'.
			static DictationResultDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResultDelegate");
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100665373);
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100665374);
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ConfidenceLevel_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100665375);
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100665376);
			}

			// Token: 0x06002F4D RID: 12109 RVA: 0x0007D27C File Offset: 0x0007B47C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationResultDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F4E RID: 12110 RVA: 0x0007D2D8 File Offset: 0x0007B4D8
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 500390, RefRangeEnd = 500401, XrefRangeStart = 500390, XrefRangeEnd = 500390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string text, ConfidenceLevel confidence)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F4F RID: 12111 RVA: 0x0007D328 File Offset: 0x0007B528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500401, XrefRangeEnd = 500405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, ConfidenceLevel confidence, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ConfidenceLevel_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F50 RID: 12112 RVA: 0x0007D3AC File Offset: 0x0007B5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F51 RID: 12113 RVA: 0x000139F4 File Offset: 0x00011BF4
			public DictationResultDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F52 RID: 12114 RVA: 0x000139FD File Offset: 0x00011BFD
			public static implicit operator DictationRecognizer.DictationResultDelegate(Action<string, ConfidenceLevel> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationResultDelegate>(A_0);
			}

			// Token: 0x06002F53 RID: 12115 RVA: 0x00013A05 File Offset: 0x00011C05
			public static DictationRecognizer.DictationResultDelegate operator +(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationResultDelegate>();
			}

			// Token: 0x06002F54 RID: 12116 RVA: 0x00013A13 File Offset: 0x00011C13
			public static DictationRecognizer.DictationResultDelegate operator -(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationResultDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001F5C RID: 8028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F5D RID: 8029
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0;

			// Token: 0x04001F5E RID: 8030
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ConfidenceLevel_AsyncCallback_Object_0;

			// Token: 0x04001F5F RID: 8031
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000895 RID: 2197
		public sealed class DictationCompletedDelegate : MulticastDelegate
		{
			// Token: 0x06002F55 RID: 12117 RVA: 0x0007D3F0 File Offset: 0x0007B5F0
			// Note: this type is marked as 'beforefieldinit'.
			static DictationCompletedDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationCompletedDelegate");
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100665377);
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100665378);
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DictationCompletionCause_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100665379);
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100665380);
			}

			// Token: 0x06002F56 RID: 12118 RVA: 0x0007D464 File Offset: 0x0007B664
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationCompletedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F57 RID: 12119 RVA: 0x0007D4C0 File Offset: 0x0007B6C0
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 500329, RefRangeEnd = 500342, XrefRangeStart = 500329, XrefRangeEnd = 500342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(DictationCompletionCause cause)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cause;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F58 RID: 12120 RVA: 0x0007D500 File Offset: 0x0007B700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500405, XrefRangeEnd = 500409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(DictationCompletionCause cause, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cause;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DictationCompletionCause_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F59 RID: 12121 RVA: 0x0007D570 File Offset: 0x0007B770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F5A RID: 12122 RVA: 0x00013A24 File Offset: 0x00011C24
			public DictationCompletedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F5B RID: 12123 RVA: 0x00013A2D File Offset: 0x00011C2D
			public static implicit operator DictationRecognizer.DictationCompletedDelegate(Action<DictationCompletionCause> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationCompletedDelegate>(A_0);
			}

			// Token: 0x06002F5C RID: 12124 RVA: 0x00013A35 File Offset: 0x00011C35
			public static DictationRecognizer.DictationCompletedDelegate operator +(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationCompletedDelegate>();
			}

			// Token: 0x06002F5D RID: 12125 RVA: 0x00013A43 File Offset: 0x00011C43
			public static DictationRecognizer.DictationCompletedDelegate operator -(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationCompletedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001F60 RID: 8032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F61 RID: 8033
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0;

			// Token: 0x04001F62 RID: 8034
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DictationCompletionCause_AsyncCallback_Object_0;

			// Token: 0x04001F63 RID: 8035
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000896 RID: 2198
		public sealed class DictationErrorHandler : MulticastDelegate
		{
			// Token: 0x06002F5E RID: 12126 RVA: 0x0007D5B4 File Offset: 0x0007B7B4
			// Note: this type is marked as 'beforefieldinit'.
			static DictationErrorHandler()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationErrorHandler");
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100665381);
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100665382);
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100665383);
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100665384);
			}

			// Token: 0x06002F5F RID: 12127 RVA: 0x0007D628 File Offset: 0x0007B828
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationErrorHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F60 RID: 12128 RVA: 0x0007D684 File Offset: 0x0007B884
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 500390, RefRangeEnd = 500401, XrefRangeStart = 500390, XrefRangeEnd = 500401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string error, int hresult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F61 RID: 12129 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500409, XrefRangeEnd = 500413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string error, int hresult, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F62 RID: 12130 RVA: 0x0007D758 File Offset: 0x0007B958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F63 RID: 12131 RVA: 0x00013A54 File Offset: 0x00011C54
			public DictationErrorHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x00013A5D File Offset: 0x00011C5D
			public static implicit operator DictationRecognizer.DictationErrorHandler(Action<string, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationErrorHandler>(A_0);
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x00013A65 File Offset: 0x00011C65
			public static DictationRecognizer.DictationErrorHandler operator +(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationErrorHandler>();
			}

			// Token: 0x06002F66 RID: 12134 RVA: 0x00013A73 File Offset: 0x00011C73
			public static DictationRecognizer.DictationErrorHandler operator -(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationErrorHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001F64 RID: 8036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001F65 RID: 8037
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0;

			// Token: 0x04001F66 RID: 8038
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_AsyncCallback_Object_0;

			// Token: 0x04001F67 RID: 8039
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
